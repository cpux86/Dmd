using Application.Wrappers;
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

        [HttpPost("api/v1/category/create/")]
        public async override Task<ActionResult<Responce<CreateCategoryResponse>>> HandleAsync(CreateCategoryRequest request, CancellationToken cancellationToken = default)
        {
            var validator = new CreateValidator();
            if (!validator.Validate(request).IsValid) 
                return BadRequest(new Response<CreateCategoryResponse>("Invalid request, error valitaion"));
            //Category category = _mapper.Map<Category>(request);
            //if (request.ParentId == null || !_repo.Find((int)request.ParentId)) 
            //    return BadRequest(new Responce<CreateCategoryResponse>("Ошибка запроса"));

            //_categoryManager.Create(category);
            //await _repo.AddAsync(category);
            //var res = _mapper.Map<CreateCategoryResponse>(category);
            var result = await _categoryManager.Create(command);
            return Ok(new Responce<CreateCategoryResponse>("test!"));

        }
    }
}
