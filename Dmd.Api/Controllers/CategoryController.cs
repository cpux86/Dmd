using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dmd.Domain.Core.Entities;
using Dmd.Infrastructure.Data;
using Dmd.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dmd.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryMenager menager;
        private ICategoryRepository repo;

        public CategoryController(ICategoryMenager m, ICategoryRepository r)
        {
            this.menager = m;
            this.repo = r;
        }


        [HttpGet]
        public IEnumerable<Category> List()
        {
            return repo.GetCategoryList();
        }


        [HttpPost]
        public async Task<ActionResult<Category>> Create(Category category)
        {

            repo.Add(category);
            
            return Ok(category);
        }
    }
}
