using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{

    public enum StatusCode
    {
        Ok = 200,
        NotFound = 404,
        Server = 500
    }


    internal class Error
    {
        public string Message { get; set; }
        public DateTime Time { get; set; }
        public string Request { get; set; }
        public StatusCode Status { get; set; }
    }
}
