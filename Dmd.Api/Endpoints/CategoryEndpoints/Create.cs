using Application.DTO.Category;
using Application.Interfaces;
using Application.Wrappers;
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
    public class Create : BaseAsyncEndpoint<CreateCategoryRequest, Responce<CreateCategoryResponse>>
    {
        private IMapper _mapper;
        private ICategoryManager _categoryManager;

        public Create(IMapper mapper, ICategoryManager manager)
        {
            _mapper = mapper;
            _categoryManager = manager;
        }

        [HttpPost("api/v1/category/create/")]
        public async override Task<ActionResult<Responce<CreateCategoryResponse>>> HandleAsync(CreateCategoryRequest request, CancellationToken cancellationToken = default)
        {
            CreateInputDTO createInputDTO = _mapper.Map<CreateInputDTO>(request);
            var result = await _categoryManager.Create(createInputDTO);
            var categoryResp = _mapper.Map<CreateCategoryResponse>(result.Data);
            if (!result.Succeeded) return BadRequest(new Responce<CreateCategoryResponse>("Invalid request."));

            return Ok(new Responce<CreateCategoryResponse>(categoryResp, "succeeded"));
        }
    }
}
