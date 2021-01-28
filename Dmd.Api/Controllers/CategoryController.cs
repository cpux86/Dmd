using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Features.Categories.Commands.CreateCategory;
using Application.Wrappers;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FluentValidation;
using Application.Interfaces;
using Application.Interfaces.Repository;

namespace Dmd.Api.Controllers
{
    //[ApiVersion("1.0")]
    public class CategoryController : BaseApiController
    {
        private ICategoryManager _categoryMenager;
        private ICategoryRepositoryAsync _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryManager m, ICategoryRepositoryAsync r, IMapper mapper)
        {
            this._categoryMenager = m;
            this._categoryRepository = r;
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
        public async Task<ActionResult<Response<int>>> Create(CreateCategoryCommand command)
        {
            var validator = new Validator();
            var result = validator.Validate(command);


            if (command.ParentId != null && !_categoryRepository.IsExist((int)command.ParentId))
                return BadRequest(new Response<int>("Invalid request"));
            return Ok(await Mediator.Send(command));
            
        }
    }
}
