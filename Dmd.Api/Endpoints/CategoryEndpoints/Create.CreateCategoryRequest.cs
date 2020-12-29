using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dmd.Api.Endpoints.CategoryEndpoints
{
    public class CreateCategoryRequest
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
    }
}
