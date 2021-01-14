using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.Categories.Commands.CreateCategory;
using Application.Wrappers;
using AutoMapper;
using Dmd.Domain.Entities;
using Dmd.Domain.Interfaces;
using Dmd.Domain.Interfaces.Repository;
using Dmd.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FluentValidation;

namespace Dmd.Api.Controllers
{
    [ApiVersion("1.0")]
    public class CategoryController : BaseApiController
    {
        private ICategoryService _categoryMenager;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService m, IMapper mapper)
        {
            this._categoryMenager = m;
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
        public async Task<ActionResult<Response<Int64>>> Create(CreateCategoryDTO command)
        {           
            var validator = new Validator();
            if (!validator.Validate(command).IsValid) return BadRequest(new Response<int>("Invalid request"));
            return await _categoryMenager.Create(command);           
        }
    }
}
