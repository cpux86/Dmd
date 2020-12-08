using AutoMapper;
using Dmd.Api.ViewModel;
using Dmd.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dmd.Api
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryViewModel>();
            
        }
    }
}
