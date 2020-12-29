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
    public class Create : BaseAsyncEndpoint<CreateCategoryRequest, CreateCategoryResponse>
    {
        private readonly ICategoryRepositoryAsync _repo;
        private IMapper _mapper;
        private ICategoryMenager _menager;

        public Create(ICategoryRepositoryAsync repo, IMapper mapper, ICategoryMenager menager)
        {
            _repo = repo;
            _mapper = mapper;
            _menager = menager;
        }

        [HttpPost("api/category/create")]
        public async override Task<ActionResult<CreateCategoryResponse>> HandleAsync(CreateCategoryRequest request, CancellationToken cancellationToken = default)
        {
            Category category = _mapper.Map<Category>(request);
            _menager.Create(category);

            var res = await _repo.AddAsync(category);
            return Ok(res);
        }
    }
}
