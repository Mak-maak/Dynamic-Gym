using DevExpress.XtraEditors;
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
    class Trainers
    {
        //attributes
        private int Id { get; set; }
        private string Name { get; set; }
        private string FatherName { get; set; }
        private int Age { get; set; }
        private string Address { get; set; }
        private DateTime JoiningDate { get; set; }
        private Image Photo { get; set; } 
             
        //method
        public void ProcessInfo(TextBox tb4, TextBox tb, TextBox tb1, TextBox tb2, TextBox tb3, DateEdit jDate, PictureBox img)
        {
            if (tb4.Text == "id" || tb3.Text == "Address" || (tb2.Text == "Age" || (Convert.ToInt16(tb2.Text) > 90) || Convert.ToInt16(tb2.Text) < 12) || tb1.Text == "Father Name" || tb.Text == "Name")
            {
                MessageBox.Show("Error! Please provide the required information.\\nTry Again.", "Error!");
            }
            else
            {
                Id = Convert.ToInt16(tb4.Text);
                Name = tb.Text;
                FatherName = tb1.Text;
                Age = Convert.ToInt16(tb2.Text);
                Address = tb3.Text;
                JoiningDate = jDate.DateTime;
                Photo = img.Image;


                //messagebox print the info to confirm it's working
                //MessageBox.Show(Id+Name+FatherName+Age+Address+JoiningDate);


                // sql operations
                //var connectionString = @"Data Source=(localdb)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.Database1.mdf;Integrated Security=True;";
                string connectionString = ConfigurationManager.ConnectionStrings["DynamicGym"].ConnectionString;
                using (SqlConnection connect = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand())
                using (MemoryStream ms = new MemoryStream())
                {
                    // code to add image to the database

                    Photo.Save(ms, Photo.RawFormat);
                    byte[] trainerImg = ms.GetBuffer();
                    ms.Close();

                    // set parameters
                    cmd.Connection = connect;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Photo", trainerImg);
                    cmd.CommandText = "insert into Trainers (id, name, fatherName, age, adress, joiningDate, photo) values ('" + Id + "' ,'" + Name + "' , '" + FatherName + "','" + Age + "','" + Address + "','" + JoiningDate + "',@Photo)";

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
