using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Exception.Utilities
{
    class HasSymbolException : ExceptionRepository
    {
        public HasSymbolException(string text)
        {
            this.Text = text;
        }
        public override string Message => "Password can not include symbols..!";
    }
}
