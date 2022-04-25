using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Exception.Utilities
{
    class HasNumberException : ExceptionRepository
    {
        public HasNumberException(string text)
        {
            this.Text = text;
            WriteExceptionToFile();
        }
        public override string Message => "First and Last name can not include numbers..!";
    }
}
