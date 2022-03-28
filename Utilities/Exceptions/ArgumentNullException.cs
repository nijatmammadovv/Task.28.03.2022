using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities.Exceptions
{
    public class ArgumentNullException:Exception
    {
        public ArgumentNullException(string message) : base(message)
        {

        }
    }
}
