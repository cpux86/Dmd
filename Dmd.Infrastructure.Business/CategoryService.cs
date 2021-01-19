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
            Task<bool> result = _categoryRepository.CategoryExist(e => e.Id == createCategoryDTO.ParentId);
            
            if (createCategoryDTO.ParentId != null && !result.Result) throw new Exception($"Category Not Found.");

            Category res = _mapper.Map<Category>(createCategoryDTO);
            List<Category> categoryList = new List<Category> { res };
            
            
            _categoryRepository.AddCategoriesList(categoryList);

            return new Response<Int64>(res.Id);
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
