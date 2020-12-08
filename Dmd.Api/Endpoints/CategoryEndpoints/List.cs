using Ardalis.ApiEndpoints;
using Dmd.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dmd.Api.Endpoints.CategoryEndpoints
{
    public class List : BaseAsyncEndpoint
    {
        private readonly ICategoryRepository _repo;

        public List(ICategoryRepository repo)
        {
            _repo = repo;
        }
        [HttpGet("api/category/list")]
        public async Task<ActionResult> HandleAsync()
        {
            var result = await _repo.GetCategoryList();

            return Ok(result);
        }
    }
}
