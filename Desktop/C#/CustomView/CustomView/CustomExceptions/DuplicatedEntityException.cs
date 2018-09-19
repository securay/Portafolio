using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomExceptions
{
    public class DuplicatedEntityException : System.Exception
    {
        public int Code { get; set; }

        public DuplicatedEntityException(int code)
        {
            Code = code;
        }
    }
}
