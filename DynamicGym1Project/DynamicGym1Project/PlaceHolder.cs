using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CitySchoolProject
{
    class PlaceHolder
    {
        public string clear = "";

        public void OnFocus(TextBox txtBoxName, string pcText)
        {
            if (txtBoxName.Text == pcText)
            {
                txtBoxName.Text = clear;
                txtBoxName.ForeColor = Color.Black;
            }
        }

        public void LoseFocus(TextBox txtBoxName, string pcText)
        {
            if (txtBoxName.Text == clear)
            {
                txtBoxName.Text = pcText;
                txtBoxName.ForeColor = Color.Gray;
            }
        }
    }
}
