using AutoMapper;
using Dmd.Api.Endpoints.CategoryEndpoints;
using Dmd.Api.ViewModel;
using Dmd.Domain.Entities;
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
            CreateMap<Category, ListResponse>()
                .ForMember("ImageUrl", opt => opt.MapFrom(c => c.ImageUrl))
                .ForMember("Items", opt => opt.MapFrom(c => c.Items.Count));
        }
    }
}
