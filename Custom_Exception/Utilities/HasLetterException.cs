using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_Exception.Utilities
{
    class HasLetterException : ExceptionRepository
    {
        public HasLetterException(string text)
        {
            this.Text = text;
            WriteExceptionToFile();
        }
        public override string Message => "Age can not include letters..!";       
    }
}
