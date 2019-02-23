using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicGym1Project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPwd.Text == "haider")
            {
                Form1 f1 = new Form1();
                f1.Show();
                Form2 f2 = new Form2();
                this.Hide();
                this.Close();
                f2.Close();
            }
            else
            {
                ErrorProvider error = new ErrorProvider();
                error.SetError(txtPwd, "Please enter correct password!");
            }
        }
    }
}
