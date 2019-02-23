using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicGym1Project
{
    class Validations
    {
        // regex for name
        Regex reName = new Regex("[a-zA-Z]{4,}(?: [a-zA-Z]+){0,2}$");

        // regex for age
        Regex reAge = new Regex("^(\\d?[1-9]|[1-9]0)$");

        
        public void Restrict(TextBox tb, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch!=8 && ch!=46)
            {
                e.Handled = true;
            }
        }
    }
}
