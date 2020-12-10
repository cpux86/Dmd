using AutoMapper;
using Dmd.Api.Endpoints.CategoryEndpoints;
using Dmd.Api.ViewModel;
using Dmd.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dmd.Api
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryViewModel>();
            CreateMap<Category, CategoryListResponse>().ForMember("ImageUrl", opt => opt.MapFrom(c => c.ImageName));
        }
    }
}
