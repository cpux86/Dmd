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

namespace Dmd.Infrastructure.Business
{
    public class CategoryMenager : ICategoryManager
    {
        private readonly ApplicationContext _context;
        private readonly ICategoryRepositoryAsync _categoryRepo;
        private readonly IMapper _mapper;

        public CategoryMenager(ApplicationContext context, ICategoryRepositoryAsync categoryRepo, IMapper mapper)
        {
            _categoryRepo = categoryRepo;
            _context = context;
            _mapper = mapper;
        }

        public CreateOutputDTO Create(CreateInputDTO createInputDTO)
        {
            //createInputDTO.
            Category category = _mapper.Map<Category>(createInputDTO);

            category.DateModified = DateTimeOffset.UtcNow;
            _categoryRepo.AddAsync(category);
            var result = _mapper.Map<CreateOutputDTO>(category);
            return result;
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
