using DevExpress.XtraEditors;
using DynamicGym1Project;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicGym1Project
{
    class Trainee
    {
        // Attributes
        // personal info
        private int Id { get; set; }
        private string Name { get; set; }
        private string FatherName { get; set; }
        private string Address { get; set; }
        private int Age { get; set; }
        private DateTime JoiningDate { get; set; }
        private Image Photo { get; set; } 

        // functional info
        private string Package { get; set; }
        private string Shift { get; set; }
        private bool Trainer { get; set; }

        // fees
        private string MonthlyFees { get; set; }

        //Methods

        public void ProcessInfo(TextBox textBox4, TextBox textBox, TextBox textBox1, TextBox textBox2, TextBox textBox3, RadioButton radioButton, RadioButton radioButton1, RadioButton morning, RadioButton evening, CheckButton checkButton, DateEdit jDate, PictureBox img)
        {
            if (textBox4.Text == "id" || (textBox3.Text == "Age" || (Convert.ToInt16(textBox3.Text) < 12|| Convert.ToInt16(textBox3.Text) > 90)) || textBox2.Text == "Address" || textBox1.Text == "Father Name" || textBox.Text == "Name")
            {
                MessageBox.Show("Error! Please provide the required information.\nTry Again.","Error!");
            } 

            else
            {
                Id = Convert.ToInt16(textBox4.Text);
                Name = textBox.Text;
                FatherName = textBox1.Text;
                Address = textBox2.Text;
                Age = Convert.ToInt16(textBox3.Text);
                JoiningDate = jDate.DateTime;
                Photo = img.Image;
                MonthlyFees = "Paid";

                // value of package
                if (radioButton.Checked)
                {
                    Package = "Regular";
                }

                if (radioButton1.Checked)
                {
                    Package = "Cardio";
                }

                // value of shift
                if (morning.Checked)
                {
                    Shift = "Morning";
                }

                if (evening.Checked)
                {
                    Shift = "Evening";
                }

                // value of trainer
                if (checkButton.Checked)
                {
                    Trainer = true;
                }

                else Trainer = false;


                // sql operations
                string connectionString = ConfigurationManager.ConnectionStrings["DynamicGym"].ConnectionString;
                using (SqlConnection connect = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand())
                using (MemoryStream ms = new MemoryStream())
                {
                    // code to add image to the database

                    Photo.Save(ms, Photo.RawFormat);
                    byte[] traineeImg = ms.GetBuffer();
                    ms.Close();

                    // set parameters
                    cmd.Connection = connect;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Photo", traineeImg);
                    cmd.CommandText = "insert into Trainee (id, name, fatherName, age, adress, joiningDate, photo, package, shift, trainer, monthlyFees) values ('" + Id + "' , '" + Name + "' , '" + FatherName + "' , '" + Age + "' , '" + Address + "' , '" + JoiningDate + "', @Photo ,'" + Package + "' , '" + Shift + "' , '" + Trainer + "' , '" + MonthlyFees + "')";

                    // open connection to the database
                    connect.Open();
                    try
                    {

                        // execute query
                        cmd.ExecuteNonQuery();

                        // close the connection 
                        connect.Close();

                        MessageBox.Show("Record inserted successfully!", "Messgae");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
       }

        // submit fees
        public void SubmitFees(int id, int feesAmount)
        {
            if (feesAmount== 500 || feesAmount == 2000 || feesAmount == 3000)
            {
                MonthlyFees = "Paid";
            }
            else
                MonthlyFees = "Un-Paid";

            // sql operations
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["DynamicGym"].ConnectionString))
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandText = "Update Trainee set monthlyFees=paid where id="+id;

                //open connection
                connect.Open();

                // execute command
                command.ExecuteNonQuery();

                // close connection
                connect.Close();

                MessageBox.Show("Trainee Id: "+id+"\nFees Updated","Message");
            }

        }

        //TODO: make this funtion work 
        public void CheckFees(int id)
        {
            // sql operations
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["DynamicGym"].ConnectionString))
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandText = "select (id,name) from Trainee where id=" + id;

                //open connection
                connect.Open();

                // execute command
                command.ExecuteNonQuery();

                // close connection
                connect.Close();

                //MessageBox.Show("Trainee Id: " + id + ", Trainee Name: "++", "Message");
            }
        }

        // load image
        public void LoadImage(PictureBox img)
        {
            try
            {
                OpenFileDialog of = new OpenFileDialog();
                of.InitialDirectory = "C:/Picture/";
                of.Filter = "All Files|*.*|JPEG|*.jpg|Bitmaps|*.bmp|GIFs|*.gif|PNG|*.png";
                of.FilterIndex = 2;
                of.Multiselect = false;
                if (of.ShowDialog() == DialogResult.OK)
                {
                    img.Image = Image.FromFile(of.FileName);
                    img.SizeMode = PictureBoxSizeMode.StretchImage;
                    img.BorderStyle = BorderStyle.Fixed3D;

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

    }
}
