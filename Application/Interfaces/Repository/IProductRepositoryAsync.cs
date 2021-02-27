using Dmd.Domain.Entities;
using Dmd.Domain.Entities.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.Repository
{
    public interface IProductRepositoryAsync : IGenericRepositoryAsync<Product>
    {
    }
}
