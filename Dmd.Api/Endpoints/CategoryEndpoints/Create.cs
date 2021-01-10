using Ardalis.ApiEndpoints;
using AutoMapper;
using Dmd.Domain.Entities;
using Dmd.Domain.Interfaces.Repository;
using Dmd.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


namespace Dmd.Api.Endpoints.CategoryEndpoints
{
    public class Create : BaseAsyncEndpoint<CreateCategoryRequest, Responce<CreateCategoryResponse>>
    {
        private readonly ICategoryRepositoryAsync _repo;
        private IMapper _mapper;
        private ICategoryManager _categoryManager;

        public Create(ICategoryRepositoryAsync repo, IMapper mapper, ICategoryManager manager)
        {
            _repo = repo;
            _mapper = mapper;
            _categoryManager = manager;
        }

        [HttpPost("api/category/create/")]
        public async override Task<ActionResult<Responce<CreateCategoryResponse>>> HandleAsync(CreateCategoryRequest request, CancellationToken cancellationToken = default)
        {
            Category category = _mapper.Map<Category>(request);
            if (request.ParentId == null || !_repo.Find((int)request.ParentId)) 
                return BadRequest(new Responce<CreateCategoryResponse>("Ошибка запроса"));

            _categoryManager.Create(category);
            await _repo.AddAsync(category);
            var res = _mapper.Map<CreateCategoryResponse>(category);
            return Ok(new Responce<CreateCategoryResponse>(res, "Готово!"));
            
        }
    }
}
