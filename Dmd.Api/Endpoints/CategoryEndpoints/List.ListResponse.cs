using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dmd.Api.Endpoints.CategoryEndpoints
{
    public class ListResponse : BaseResponse
    {
        public int Id { get; set; }
        public int Items { get; set; }
    }
}
