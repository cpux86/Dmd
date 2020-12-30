using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dmd.Api.Endpoints
{
    public class Responce<T>
    {
        public Responce(T data, string message = null)
        {
            Succeeded = true;
            Message = message;
            Data = data;
        }
        public Responce(string message)
        {
            Succeeded = false;
            Message = message;
        }

        public bool Succeeded { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }
        public T Data { get; set; }
    }
}
