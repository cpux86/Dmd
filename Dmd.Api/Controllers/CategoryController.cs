using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Dmd.Api.ViewModel;
using Dmd.Domain.Core.Entities;
using Dmd.Domain.Interfaces;
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
        private readonly IMapper _mapper;

        public CategoryController(ICategoryMenager m, ICategoryRepository r, IMapper mapper)
        {
            this.menager = m;
            this.repo = r;
            _mapper = mapper;
        }


        //[HttpGet]
        //public List<CategoryViewModel> List()
        //{
        //    var cat =  repo.GetCategoryList();
        //    var catViewModel = _mapper.Map<IEnumerable<Category>, List<CategoryViewModel>>(cat);
        //    return catViewModel;
        //}


        [HttpPost]
        public ActionResult<Category> Create(Category category)
        {

            repo.Add(category);
            
            return Ok(category);
        }

    }
}
