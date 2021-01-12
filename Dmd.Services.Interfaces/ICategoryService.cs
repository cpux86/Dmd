using Application.Features.Categories.Commands.CreateCategory;
using Application.Wrappers;
using Dmd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dmd.Services.Interfaces
{
    public interface ICategoryService
    {
        public Task<Response<int>> Create(CreateCategoryDTO command);
        //public void Delete(int catId);
        //public void Save();
    }
}
