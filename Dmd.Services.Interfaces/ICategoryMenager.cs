using Dmd.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dmd.Services.Interfaces
{
    public interface ICategoryMenager
    {
        public Category Create(Category category);
    }
}
