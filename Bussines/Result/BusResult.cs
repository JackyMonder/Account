using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bus.IResult
{
    internal class BusResult : IResult
    {   
        public int Status { get; set; }
        public string? Message { get; set; }
        public object? Data { get; set; }

        public BusResult()
        {
            Status = -1;
            Message = "Action fail";
        }

        public BusResult(int status, string message)
        {
            Status = status;
            Message = message;
        }

        public BusResult(int status, string message, object data)
        {
            Status = status;
            Message = message;
            Data = data;
        }
    }
}
