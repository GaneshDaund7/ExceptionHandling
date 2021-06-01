using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionHandling1
{
    public class InvalidNumberException:Exception
    {
        public InvalidNumberException(string msg)
            : base(msg)
        { }

    }
}
