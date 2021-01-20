using Application.Features.Categories.Commands.CreateCategory;
using Application.Wrappers;
using AutoMapper;
using Dmd.Domain.Entities;
using Dmd.Domain.Interfaces.Repository;
using Dmd.Infrastructure.Data;
using Dmd.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dmd.Infrastructure.Business
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepositoryAsync _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryService(ICategoryRepositoryAsync categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        //public Category Create(Category category)
        //{
        //    if (command.ParentId != null && !_categoryRepository.Find((int)command.ParentId))
        //}

        public async Task<Response<Int64>> Create(CreateCategoryDTO createCategoryDTO)
        {
            // является ли новая категория вложеной, если да, то ищем в базе данный родителя для неё.
            Task<bool> result;
          if (createCategoryDTO.ParentId > 0) {
                result = _categoryRepository.CategoryExist(e => e.Id == createCategoryDTO.ParentId);
            }
            




           // if (createCategoryDTO.ParentId != null && !result.Result) throw new Exception($"Category Not Found.");

            Category category = _mapper.Map<Category>(createCategoryDTO);
            _categoryRepository.AddAsync(category);
            
            //_categoryRepository.AddCategoryAsync(res);

            return new Response<Int64>(category.Id);
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
