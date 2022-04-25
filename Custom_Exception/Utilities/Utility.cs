using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_Exception.Utilities
{
    public static class Utility
    {
        public static void Clear(GroupBox grp)
        {
            foreach (Control control in grp.Controls)
                if (control is TextBox)
                    control.Text = string.Empty;
        }
        public static string GenerateCaptcha() => Guid.NewGuid().ToString().Split('-')[1];

        public static void CheckForLetter(string text)
        {
            foreach (char character in text)
                if (char.IsLetter(character))
                    throw new HasLetterException(text);
        }

        public static void CheckforNumber(string text)
        {
            foreach (char character in text)
                if (char.IsDigit(character))
                    throw new HasNumberException(text);
        }

        public static void CheckforSymbol(string text)
        {
            foreach (char character in text)
                if (char.IsSymbol(character))
                    throw new HasSymbolException(text);
        }
    }
}
