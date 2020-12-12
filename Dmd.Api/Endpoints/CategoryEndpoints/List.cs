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
    public class List : BaseAsyncEndpoint<ListRequest, ListResponse>
    {
        private readonly ICategoryRepository _repo;
        private IMapper _mapper;

        public List(ICategoryRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet("api/category/list/{Id}")]
        public async override Task<ActionResult<ListResponse>> HandleAsync([FromRoute] ListRequest request, CancellationToken cancellationToken = default)
        {
            IEnumerable<ListResponse> result = (await _repo.GetCategoryList(request.Id))
                .Select(_mapper.Map<ListResponse>);
            return Ok(result);
        }
    }
}
