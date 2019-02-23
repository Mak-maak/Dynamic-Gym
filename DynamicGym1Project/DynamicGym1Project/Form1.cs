using CitySchoolProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicGym1Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // instantiate validation class
        Validations validate = new Validations();

        // instantiate imagegalley class
        ImageGallery imgs = new ImageGallery();

        // instantiate placeholder class
        PlaceHolder placeholder = new PlaceHolder();

        // instantiate intake calculater class
        IntakeCalculator intake = new IntakeCalculator();

        // instantiate trainer and trainee class
        Trainers trainer = new Trainers();
        Trainee trainee = new Trainee();

        // int image counter variable
        int imgCounter = 0;
        
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (imgCounter < 1)
            {
                imgGallery.Image = imageList.Images[imgCounter];
                //MessageBox.Show(imgCounter + " " + imageList.Images.Count);
            }
            else if (imgCounter > 0 && imgCounter < imageList.Images.Count)
            {
                imgGallery.Image = imageList.Images[imgCounter];
                //MessageBox.Show(imgCounter + " " + imageList.Images.Count);
            }
            imgCounter++;


            if (imgCounter > imageList.Images.Count - 1)
            {
                imgCounter = 0;
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            imgCounter--;
            if (imgCounter == 0)
            {
                imgGallery.Image = imageList.Images[imgCounter];
                //MessageBox.Show(imgCounter + " " + imageList.Images.Count);
            }
            if (imgCounter > 0 && imgCounter < imageList.Images.Count)
            {
                imgGallery.Image = imageList.Images[imgCounter];
                //MessageBox.Show(imgCounter + " " + imageList.Images.Count);
            }
            
            if (imgCounter < 0)
            {
                imgCounter = imageList.Images.Count - 1;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.bodybuilding.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.t-nation.com/");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.muscleandfitness.com/");        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.getbig.com/headlines/");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.musculardevelopment.com/");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.stronglifts.com/");
        }

        private void xtraTabControl2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.bodybuilding.com/fun/nutrition-101-eat-to-build-lean-muscle.html");
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.bodybuilding.com/fun/brewster26.htm");
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.muscleandfitness.com/nutrition/meal-plans/mass-gaining-meal-plan");
        }

        private void xtraTabPage10_Paint(object sender, PaintEventArgs e)
        {

        }

        #region TextBox PlaceHolder Text Events

        // id
        private void txtIdGotFocus(object sender, EventArgs e)
        {
            TextBox txtId = (TextBox)sender;
            placeholder.OnFocus(txtId, "id");
        }
        private void txtIdLostFocus(object sender, EventArgs e)
        {
            TextBox txtId = (TextBox)sender;
            placeholder.LoseFocus(txtId, "id");
        }

        // Name
        private void txtNameGotFocus(object sender, EventArgs e)
        {
            TextBox txtName = (TextBox)sender;
            placeholder.OnFocus(txtName, "Name");
        }
        private void txtNameLostFocus(object sender, EventArgs e)
        {
            TextBox txtName = (TextBox)sender;
            placeholder.LoseFocus(txtName, "Name");
        }

        // Father Name
        private void txtFNameGotFocus(object sender, EventArgs e)
        {
            TextBox txtFName = (TextBox)sender;
            placeholder.OnFocus(txtFName, "Father Name");
        }
        private void txtFNameLostFocus(object sender, EventArgs e)
        {
            TextBox txtFName = (TextBox)sender;
            placeholder.LoseFocus(txtFName, "Father Name");
        }

        // Address
        private void txtAddressGotFocus(object sender, EventArgs e)
        {
            TextBox txtAddress = (TextBox)sender;
            placeholder.OnFocus(txtAddress, "Address");
        }
        private void txtAddressLostFocus(object sender, EventArgs e)
        {
            TextBox txtAddress = (TextBox)sender;
            placeholder.LoseFocus(txtAddress, "Address");
        }

        // Age
        private void txtAgeGotFocus(object sender, EventArgs e)
        {
            TextBox txtAge = (TextBox)sender;
            placeholder.OnFocus(txtAge, "Age");
        }
        private void txtAgeLostFocus(object sender, EventArgs e)
        {
            TextBox txtAge = (TextBox)sender;
            placeholder.LoseFocus(txtAge, "Age");
        }

        // weight protein calculator
        private void txtWeightProGotFocus(object sender, EventArgs e)
        {
            TextBox txtWeightPro = (TextBox)sender;
            placeholder.OnFocus(txtWeightPro, "Weight in Kg");
        }
        private void txtWeightProLostFocus(object sender, EventArgs e)
        {
            TextBox txtWeightPro = (TextBox)sender;
            placeholder.LoseFocus(txtWeightPro, "Weight in Kg");
        }

        //Calorie Calculator
        // weight
        private void txtWeightCalGotFocus(object sender, EventArgs e)
        {
            TextBox txtWeightCal = (TextBox)sender;
            placeholder.OnFocus(txtWeightCal, "Weight in Kg");
        }
        private void txtWeightCalLostFocus(object sender, EventArgs e)
        {
            TextBox txtWeightCal = (TextBox)sender;
            placeholder.LoseFocus(txtWeightCal, "Weight in Kg");
        }

        // Height
        private void txtHeightCalGotFocus(object sender, EventArgs e)
        {
            TextBox txtHeightCal = (TextBox)sender;
            placeholder.OnFocus(txtHeightCal, "Height in Inches");
        }
        private void txtHeightCalLostFocus(object sender, EventArgs e)
        {
            TextBox txtHeightCal = (TextBox)sender;
            placeholder.LoseFocus(txtHeightCal, "Height in Inches");
        }

        // age 
        private void txtAgeCalGotFocus(object sender, EventArgs e)
        {
            TextBox txtAgeCal = (TextBox)sender;
            placeholder.OnFocus(txtAgeCal, "Age");
        }
        private void txtAgeCalLostFocus(object sender, EventArgs e)
        {
            TextBox txtAgeCal = (TextBox)sender;
            placeholder.LoseFocus(txtAgeCal, "Age");
        }

        // fees
        //id
        private void txtTraineeIdGotFocus(object sender, EventArgs e)
        {
            TextBox txtTraineeId = (TextBox)sender;
            placeholder.OnFocus(txtTraineeId,"Trainee id");
        }
        private void txtTraineeIdLostFocus(object sender, EventArgs e)
        {
            TextBox txtTraineeId = (TextBox)sender;
            placeholder.LoseFocus(txtTraineeId, "Trainee id");
        }

        // amount
        private void txtAmountGotFocus(object sender, EventArgs e)
        {
            TextBox txtAmount = (TextBox)sender;
            placeholder.OnFocus(txtAmount, "Amount");
        }
        private void txtAmountLostFocus(object sender, EventArgs e)
        {
            TextBox txtAmount = (TextBox)sender;
            placeholder.LoseFocus(txtAmount, "Amount");
        }

        // id for check
        private void txtTraineeIdCheckGotFocus(object sender, EventArgs e)
        {
            TextBox txtTraineeIdCheck = (TextBox)sender;
            placeholder.OnFocus(txtTraineeIdCheck, "Trainee id");
        }
        private void txtTraineeIdCheckLostFocus(object sender, EventArgs e)
        {
            TextBox txtTraineeIdCheck = (TextBox)sender;
            placeholder.LoseFocus(txtTraineeIdCheck, "Trainee id");
        }

        //trainer
        // id
        private void txtIdTrainerGotFocus(object sender, EventArgs e)
        {
            TextBox txtIdTrainer = (TextBox)sender;
            placeholder.OnFocus(txtIdTrainer, "id");
        }
        private void txtIdTrainerLostFocus(object sender, EventArgs e)
        {
            TextBox txtIdTrainer = (TextBox)sender;
            placeholder.LoseFocus(txtIdTrainer, "id");
        }

        // Name
        private void txtNameTrainerGotFocus(object sender, EventArgs e)
        {
            TextBox txtNameTrainer = (TextBox)sender;
            placeholder.OnFocus(txtNameTrainer, "Name");
        }
        private void txtNameTrainerLostFocus(object sender, EventArgs e)
        {
            TextBox txtNameTrainer = (TextBox)sender;
            placeholder.LoseFocus(txtNameTrainer, "Name");
        }

        // Father Name
        private void txtFNameTrainerGotFocus(object sender, EventArgs e)
        {
            TextBox txtFNameTrainer = (TextBox)sender;
            placeholder.OnFocus(txtFNameTrainer, "Father Name");
        }
        private void txtFNameTrainerLostFocus(object sender, EventArgs e)
        {
            TextBox txtFNameTrainer = (TextBox)sender;
            placeholder.LoseFocus(txtFNameTrainer, "Father Name");
        }

        // Address
        private void txtAddressTrainerGotFocus(object sender, EventArgs e)
        {
            TextBox txtAddressTrainer = (TextBox)sender;
            placeholder.OnFocus(txtAddressTrainer, "Address");
        }
        private void txtAddressTrainerLostFocus(object sender, EventArgs e)
        {
            TextBox txtAddressTrainer = (TextBox)sender;
            placeholder.LoseFocus(txtAddressTrainer, "Address");
        }

        // Age
        private void txtAgeTrainerGotFocus(object sender, EventArgs e)
        {
            TextBox txtAgeTrainer = (TextBox)sender;
            placeholder.OnFocus(txtAgeTrainer, "Age");
        }
        private void txtAgeTrainerLostFocus(object sender, EventArgs e)
        {
            TextBox txtAgeTrainer = (TextBox)sender;
            placeholder.LoseFocus(txtAgeTrainer, "Age");
        }


        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dynamicGymDataSet3.Trainer' table. You can move, or remove it, as needed.
            this.trainerTableAdapter1.Fill(this.dynamicGymDataSet3.Trainer);
            // TODO: This line of code loads data into the 'dynamicGymDataSet2.Trainee' table. You can move, or remove it, as needed.
            this.traineeTableAdapter1.Fill(this.dynamicGymDataSet2.Trainee);
            // TODO: This line of code loads data into the 'dynamicGymDataSet1.Trainer' table. You can move, or remove it, as needed.
           // this.trainerTableAdapter.Fill(this.dynamicGymDataSet1.Trainer);
            // TODO: This line of code loads data into the 'dynamicGymDataSet.Trainee' table. You can move, or remove it, as needed.
           // this.traineeTableAdapter.Fill(this.dynamicGymDataSet.Trainee);
            // add trainee
            txtId.GotFocus += new EventHandler(this.txtIdGotFocus);
            txtId.LostFocus += new EventHandler(this.txtIdLostFocus);

            txtName.GotFocus += new EventHandler(this.txtNameGotFocus);
            txtName.LostFocus += new EventHandler(this.txtNameLostFocus);

            txtFName.GotFocus += new EventHandler(this.txtFNameGotFocus);
            txtFName.LostFocus += new EventHandler(this.txtFNameLostFocus);

            txtAddress.GotFocus += new EventHandler(this.txtAddressGotFocus);
            txtAddress.LostFocus += new EventHandler(this.txtAddressLostFocus);

            txtAge.GotFocus += new EventHandler(this.txtAgeGotFocus);
            txtAge.LostFocus += new EventHandler(this.txtAgeLostFocus);

            // protein calculator
            txtWeightPro.GotFocus += new EventHandler(this.txtWeightProGotFocus);
            txtWeightPro.LostFocus += new EventHandler(this.txtWeightProLostFocus);

            // calorie calculator
            txtWeightCal.GotFocus += new EventHandler(this.txtWeightCalGotFocus);
            txtWeightCal.LostFocus += new EventHandler(this.txtWeightCalLostFocus);

            txtHeightCal.GotFocus += new EventHandler(this.txtHeightCalGotFocus);
            txtHeightCal.LostFocus += new EventHandler(this.txtHeightCalLostFocus);

            txtAgeCal.GotFocus += new EventHandler(this.txtAgeCalGotFocus);
            txtAgeCal.LostFocus += new EventHandler(this.txtAgeCalLostFocus);

            // fees
            txtTraineeId.GotFocus += new EventHandler(this.txtTraineeIdGotFocus);
            txtTraineeId.LostFocus += new EventHandler(this.txtTraineeIdLostFocus);

            txtAmount.GotFocus += new EventHandler(this.txtAmountGotFocus);
            txtAmount.LostFocus += new EventHandler(this.txtAmountLostFocus);

            txtTraineeIdCheck.GotFocus += new EventHandler(this.txtTraineeIdCheckGotFocus);
            txtTraineeIdCheck.LostFocus += new EventHandler(this.txtTraineeIdCheckLostFocus);

            // trainer
            txtIdTrainer.GotFocus += new EventHandler(this.txtIdTrainerGotFocus);
            txtIdTrainer.LostFocus += new EventHandler(this.txtIdTrainerLostFocus);

            txtNameTrainer.GotFocus += new EventHandler(this.txtNameTrainerGotFocus);
            txtNameTrainer.LostFocus += new EventHandler(this.txtNameTrainerLostFocus);

            txtFNameTrainer.GotFocus += new EventHandler(this.txtFNameTrainerGotFocus);
            txtFNameTrainer.LostFocus += new EventHandler(this.txtFNameTrainerLostFocus);

            txtAddressTrainer.GotFocus += new EventHandler(this.txtAddressTrainerGotFocus);
            txtAddressTrainer.LostFocus += new EventHandler(this.txtAddressTrainerLostFocus);

            txtAgeTrainer.GotFocus += new EventHandler(this.txtAgeTrainerGotFocus);
            txtAgeTrainer.LostFocus += new EventHandler(this.txtAgeTrainerLostFocus);


        }

        private void btnCalculatePro_Click(object sender, EventArgs e)
        {
            double weight;
            if (txtWeightPro.Text != "Weight in Kg")
            {
                // invoke a method protein calculator of class IntakeCalculator
                weight = Convert.ToDouble(txtWeightPro.Text);
                proteinIntake.Text = intake.ProteinCalculator(weight);
            }
            else MessageBox.Show("Error! Please provide the weight first in Kg.\nPlease Try Again.", "Error!");
            
            
        }

        private void btnCalculateCal_Click(object sender, EventArgs e)
        {
            if (txtWeightCal.Text != "Weight in Kg" || txtHeightCal.Text != "Height in Inches" || txtAgeCal.Text != "Age")
            {
                double weight = Convert.ToDouble(txtWeightCal.Text);
                double height = Convert.ToDouble(txtHeightCal.Text);
                int age = Convert.ToInt16(txtAgeCal.Text);

                int status = 0;
                if ((string)comboBox1.SelectedItem == "Lightly Active")
                {
                    status = 1;
                }

                if ((string)comboBox1.SelectedItem == "Moderately Active")
                {
                    status = 2;
                }

                if ((string)comboBox1.SelectedItem == "Very Active")
                {
                    status = 3;
                }

                if ((string)comboBox1.SelectedItem == "Extremely Active")
                {
                    status = 4;
                }

                calorieIntake.Text = intake.CalorieCalculator(weight, height, age, status);
            }
            else MessageBox.Show("Error! Please provide the required information to calculate daily calorie(s) intake.\nPlease Try Again.", "Error!");

            }

        private void btnLoadImg_Click(object sender, EventArgs e)
        {
            trainer.LoadImage(imgTrainer);
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            trainee.LoadImage(imgTrainee);
        }

        private void btnAddTrainer_Click(object sender, EventArgs e)
        {
            trainer.ProcessInfo(txtIdTrainer,txtNameTrainer,txtFNameTrainer,txtAgeTrainer,txtAddressTrainer,dateJoinTrainer,imgTrainer);
            imgTrainer.Image = null;
        }

        private void btnAddTrainee_Click(object sender, EventArgs e)
        {
            trainee.ProcessInfo(txtId, txtName, txtFName, txtAddress, txtAge, rdbRegular, rdbCardio, rdbMorning, rdbEvening, chkBtnAddTrainer, joiningDate, imgTrainee);
            imgTrainee.Image = null;
        }

        private void btnAddImg_Click(object sender, EventArgs e)
        {
            imgs.LoadNAddImage(imgGallery,imageList);
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.facebook.com/SAMSOrganizers/?ref=aymt_homepage_panel");
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.Restrict(txtId, e);
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.Restrict(txtAge, e);
        }

        private void txtIdTrainer_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.Restrict(txtIdTrainer, e);
        }

        private void txtAgeTrainer_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.Restrict(txtAgeTrainer,e);
        }

        private void txtWeightPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.Restrict(txtWeightPro,e);
        }

        private void txtWeightCal_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.Restrict(txtWeightCal, e);
        }

        private void txtHeightCal_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.Restrict(txtHeightCal, e);
        }

        private void txtAgeCal_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.Restrict(txtAgeCal, e);
        }

        private void txtTraineeId_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.Restrict(txtTraineeId, e);
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.Restrict(txtAmount, e);
        }

        private void txtTraineeIdCheck_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.Restrict(txtTraineeIdCheck, e);
        }
       
    }
    
}