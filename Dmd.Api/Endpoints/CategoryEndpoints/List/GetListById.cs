using Ardalis.ApiEndpoints;
using AutoMapper;
using Dmd.Domain.Entities;
using Dmd.Domain.Interfaces;
using Dmd.Domain.Interfaces.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Dmd.Api.Endpoints.CategoryEndpoints
{
    public class GetListById : BaseAsyncEndpoint<ListRequest, ListResponse>
    {
        private readonly ICategoryRepositoryAsync _repo;
        private IMapper _mapper;

        public GetListById(ICategoryRepositoryAsync repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet("api/category/list/{Id}")]
        public async override Task<ActionResult<ListResponse>> HandleAsync([FromRoute] ListRequest request, CancellationToken cancellationToken = default)
        {
            //var res = await _repo.GetByIdAsync(request.Id);
            //IEnumerable<ListResponse> result = (await _repo.GetCategoryList(request.Id))
            //    .Select(_mapper.Map<ListResponse>);
            //return Ok(result);

            //var res = await _repo.GetByIdAsync(request.Id);
            IEnumerable<ListResponse> result = (await _repo.GetCategoryList(e=>e.Title == "Level 1" || e.Title == "Овощи"))
                .Select(_mapper.Map<ListResponse>);
            return Ok(result);
        }


    }
}
