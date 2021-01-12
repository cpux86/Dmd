using MediatR;
using Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Dmd.Domain.Interfaces.Repository;
using AutoMapper;
using Dmd.Domain.Entities;

namespace Application.Features.Categories.Commands.CreateCategory
{
    public class CreateCategoryDTO
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
    }
}
