using Application.Interfaces.Repository;
using Ardalis.ApiEndpoints;
using AutoMapper;
using Dmd.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Dmd.Api.Endpoints.CategoryEndpoints
{
    public class GetListById : BaseAsyncEndpoint<ListRequest,  ListResponse>
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

            IEnumerable<ListResponse> result = (await _repo.ListAsync(e=>e.ParentId == request.Id))
                .Select(_mapper.Map<ListResponse>);
            return Ok(new Responce<IEnumerable<ListResponse>>(result));

        }


    }
}
