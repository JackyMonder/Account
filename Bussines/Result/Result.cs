using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bus.Result.Result;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bus.Result
{
    internal class Result : IResult
    {
        public int Status { get; set; }
        public string? Message { get; set; }
        public object? Data { get; set; }

        public Result()
        {
            Status = -1;
            Message = "Action fail";
        }

        public Result(int status, string message)
        {
            Status = status;
            Message = message;
        }

        public Result(int status, string message, object data)
        {
            Status = status;
            Message = message;
            Data = data;
        }
    }
}
