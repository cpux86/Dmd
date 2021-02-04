using Application.DTO.Category;
using Application.Interfaces;
using Application.Interfaces.Repository;
using Application.Wrappers;
using AutoMapper;
using Dmd.Domain.Entities;
using Dmd.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dmd.Infrastructure.Business
{
    public class CategoryMenager : ICategoryManager
    {
        private readonly ICategoryRepositoryAsync _categoryRepo;
        private readonly IMapper _mapper;

        public CategoryMenager(ICategoryRepositoryAsync categoryRepo, IMapper mapper)
        {
            _categoryRepo = categoryRepo;
            _mapper = mapper;
        }

        public async Task<Response<CreateOutputDTO>> Create(CreateInputDTO createInputDTO)
        {
            try
            {
                var category = _mapper.Map<Category>(createInputDTO);
                category.DateModified = DateTimeOffset.UtcNow;
                await _categoryRepo.AddAsync(category);
                var result = _mapper.Map<CreateOutputDTO>(category);
                return new Response<CreateOutputDTO>(result);
            }
            catch (Exception e)
            {

                return new Response<CreateOutputDTO>("request error");
            }
            
        }

        //public void Delete(int catId)
        //{

        //    throw new NotImplementedException();
        //}

        //public async void Save()
        //{
        //    await _context.AddAsync(_category);
        //}
    }
}
