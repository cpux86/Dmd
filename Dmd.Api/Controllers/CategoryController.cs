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
            //List<Category> cat = new List<Category>
            //{
            //    new Category { Title = "Кат"},
            //    new Category { Title = "Кат 2"},
            //    new Category { Title = "Кат 3"},
            //    new Category { Title = "Кат 4"},
            //};

            //repo.Add(cat);
            //return cat;
            return repo.GetCategoryList();
        }
    }
}
