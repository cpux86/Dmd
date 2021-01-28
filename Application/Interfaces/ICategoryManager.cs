using Application.DTO.Category;
using Application.Wrappers;
using Dmd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ICategoryManager
    {
        public Task<Response<CreateOutputDTO>> Create(CreateInputDTO category);
        //public void Delete(int catId);
        //public void Save();
    }
}
