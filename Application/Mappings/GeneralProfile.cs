using Application.Features.Categories.Commands.CreateCategory;
using AutoMapper;
using Dmd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<CreateCategoryCommand, Category>();
        }
    }
}
