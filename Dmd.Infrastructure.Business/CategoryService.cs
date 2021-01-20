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
        private readonly ICategoryRepositoryAsync _categoryRepo;
        private readonly IMapper _mapper;
        public CategoryService(ICategoryRepositoryAsync categoryRepository, IMapper mapper)
        {
            _categoryRepo = categoryRepository;
            _mapper = mapper;
        }

        public async Task<Response<Int64>> Create(CreateCategoryDTO createCategoryDTO)
        {
            // является ли новая категория вложенной.
            if (createCategoryDTO.ParentId != null)
            {
                // ищем в БД указанного родителя
                var isExist = await _categoryRepo.CategoryExist(e => e.Id == createCategoryDTO.ParentId);
                // если родитель не найден в БД, то возращаем ошибку
                if (!isExist) return new Response<Int64>("Category Not Found.");
            }

            Category category = _mapper.Map<Category>(createCategoryDTO);
            _categoryRepo.AddAsync(category);
            return new Response<Int64>(category.Id);
        }
    }
}
