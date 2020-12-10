using Ardalis.ApiEndpoints;
using AutoMapper;
using Dmd.Domain.Core.Entities;
using Dmd.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Dmd.Api.Endpoints.CategoryEndpoints
{
    public class List : BaseAsyncEndpoint<CategoryResponse>
    {
        private readonly ICategoryRepository _repo;
        private  IMapper _mapper;

        public List(ICategoryRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        //[HttpGet("api/category/list")]
        //public async Task<ActionResult> HandleAsync()
        //{
        //    var result = await _repo.GetCategoryList();

        //    return Ok(result);
        //}

        [HttpGet("api/category/list")]
        public async override Task<ActionResult<CategoryResponse>> HandleAsync(CancellationToken cancellationToken = default)
        {
            IEnumerable<CategoryResponse> result = (await _repo.GetCategoryList()).Select(_mapper.Map<CategoryResponse>);

            return Ok(result);
        }

        //[HttpGet("api/category/list")]
        //public async override Task<ActionResult<CategoryResponse>> HandleAsync(CancellationToken cancellationToken = default)
        //{
        //    //IEnumerable<CategoryResponse> result = _r
        //    var result = await _repo.GetCategoryList();

        //    return Ok(result);
        //}
    }
}
