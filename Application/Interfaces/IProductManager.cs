using Application.DTO.Product;
using Dmd.Domain.Entities;
using Dmd.Domain.Entities.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface IProductManager
    {
        public List<Property> AllProperties(int categoryId);
        public void SaveProduct(ProductDTO productInputDTO);
    }
}
