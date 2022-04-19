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
    }
}
