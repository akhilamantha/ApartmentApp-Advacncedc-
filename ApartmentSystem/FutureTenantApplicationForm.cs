using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using ApartmentSystem.DAL; // importing data access layers properties to futureTenenatApplicationForm 

namespace ApartmentSystem
{
    public partial class FutureTenantApplicationForm : Form
    {
        public FutureTenantApplicationForm()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close(); // button2 stands for the exit button.
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string rbText = ""; // used to insert radiobox checked values.
            string rbText2 = "";


            //SqlConnection con = new SqlConnection(aptConnectionString);

            //SqlCommand cmd = new SqlCommand("insert into Tenant values(@tenantid, @fname, @lname,@ssn ,@aptype, @numofres, @petyn)", con);
            //cmd.Parameters.AddWithValue("@tenantid", textBoxApplicationNumber.Text);
            //cmd.Parameters.AddWithValue("@fname", textBoxFirstName.Text);
            //cmd.Parameters.AddWithValue("@lname", textBoxLastName.Text);
            //cmd.Parameters.AddWithValue("@ssn", Convert.ToInt32(textBoxLast4DigitsSSN.Text));
            //cmd.Parameters.AddWithValue("@numofres", Convert.ToInt32(textBoxNumberOfResidents.Text));
            

            if (string.IsNullOrEmpty(textBoxApplicationNumber.Text) || string.IsNullOrEmpty(textBoxFirstName.Text) ||
                 string.IsNullOrEmpty(textBoxLastName.Text) ||
                 string.IsNullOrEmpty(textBoxLast4DigitsSSN.Text) ||
                 string.IsNullOrEmpty(textBoxNumberOfResidents.Text)) // checking wether all the input fields are empty or not when empty displays the below mentioned messages.
            {
                //setting error  for application number
                if (string.IsNullOrEmpty(textBoxApplicationNumber.Text))
                {
                    textBoxApplicationNumber.Focus();
                    FutureTenantFormErrorProvider.SetError(textBoxApplicationNumber, "Please enter application number");
                }
                //setting error for first name
                if (string.IsNullOrEmpty(textBoxFirstName.Text))
                {
                    textBoxFirstName.Focus();
                    FutureTenantFormErrorProvider.SetError(textBoxFirstName, "Please enter first name of applicant");
                }
                //setting error for last name
                if (string.IsNullOrEmpty(textBoxLastName.Text))
                {
                    textBoxLastName.Focus();
                    FutureTenantFormErrorProvider.SetError(textBoxLastName, "Please enter last name of applicant");
                }

                //setting error for ssn field
                if (string.IsNullOrEmpty(textBoxLast4DigitsSSN.Text))
                {
                    textBoxLast4DigitsSSN.Focus();
                    FutureTenantFormErrorProvider.SetError(textBoxLast4DigitsSSN, "Please enter last 4 digit of ssn");
                }
                //setting error for no. of resident
                if (string.IsNullOrEmpty(textBoxNumberOfResidents.Text))
                {
                    textBoxNumberOfResidents.Focus();
                    FutureTenantFormErrorProvider.SetError(textBoxNumberOfResidents, "Please enter number of residents");
                }
            }// end of checking input fields (only textboxes) are empty or not
            else
            {
                if (textBoxLast4DigitsSSN.Text.Length != 4)
                {
                    textBoxLast4DigitsSSN.Focus();
                    FutureTenantFormErrorProvider.SetError(textBoxLast4DigitsSSN, "Please enter last 4 digits");
                }//end of checking length of last 4 digits of ssn
                else
                {


                    if (radioButtonStudio.Checked || radioButtonSingle.Checked || radioButtonDoubleBedroom.Checked || radioButtonTrippleBedroom.Checked)
                    {  //main flow starts now


                        if (radioButtonPetsYes.Checked)
                        {
                            rbText2 = radioButtonPetsYes.Text; // when pets is checked with yes its values are stored in the variable rbText2 and as follows 
                        }
                        if (radioButtonPetsNo.Checked)
                        {
                            rbText2 = radioButtonPetsNo.Text;
                        }
                        if (radioButtonSingle.Checked)
                        {
                            rbText = radioButtonSingle.Text;
                        }
                        if (radioButtonDoubleBedroom.Checked)
                        {
                            rbText = radioButtonDoubleBedroom.Text;
                        }
                        if (radioButtonTrippleBedroom.Checked)
                        {
                            rbText = radioButtonTrippleBedroom.Text;
                        }
                        if (radioButtonStudio.Checked)
                        {
                            rbText = radioButtonStudio.Text;
                        }

                        //cmd.Parameters.AddWithValue("@aptype", rbText);
                        //cmd.Parameters.AddWithValue("@petyn", rbText2);

                        // con.Open();

                        TenantDetails objTenantDetails = new TenantDetails // all the futureTenantApplication form textfields are in the TenantDetails class of entity folder so created a object for tenantDetails and made the variables available to the current form.
                        {
                            Tenantid = int.Parse(textBoxApplicationNumber.Text),
                            FirstName = textBoxFirstName.Text,
                            LastName = textBoxLastName.Text,
                            NumberOfFres = int.Parse(textBoxNumberOfResidents.Text),
                            SSN = textBoxLast4DigitsSSN.Text,
                            ApartmentType = rbText,
                            IsPetsAvailable = rbText2

                        };
                        FutureTenantDAL futureTenantDALobject = new FutureTenantDAL();   //we need to insert the values entered by the user to the database so we create a object of FutureTenantDAL which has saveTenantDetails method which saves all the entered details.
                        int tenantID = futureTenantDALobject.SaveTenantDetails(objTenantDetails); // in order to display the message data inserted successfully we need to show in accordance with any variable value like we did rowCount in the LoginForm.
                        //int i = cmd.ExecuteNonQuery();
                        if (tenantID != 0) // so we check with the tenantID property to know wether data is inserted successfully or not.
                        {
                            MessageBox.Show("Data Inserted!");
                            //textBoxApplicationNumber.Text = "";
                            //textBoxFirstName.Text = "";
                            //textBoxLastName.Text = "";
                            //textBoxLast4DigitsSSN.Text = "";
                            //textBoxNumberOfResidents.Text = "";
                            //textBoxApplicationNumber.Focus();
                            foreach (TextBox tb in this.Controls.OfType<TextBox>())
                                tb.Text = string.Empty; // after successful insertion of data into the table all the fields are set to empty making it ready for next user detail.

                        }
                    }//end of if of checking radio button of type of flat
                    else
                    {

                        FutureTenantFormErrorProvider.SetError(TypeOfFlatlabel, "Please select type of flat"); 
                    }//end of else of checking type of flatLabel
                }//end of else of checking lenght of ssn
                // con.Close();
            }//end of else of checking all textboxes empty or not
        }

        private void textBoxLast4DigitsSSN_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch)&& ch != 8 && ch != 46)  // the 8 is the ASCII value for backspace and 46 is for delete, only digits , backspaces and delete will work in the input textbox.
            {
                e.Handled = true;
            }
        }

        private void textBoxNumberOfResidents_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBoxApplicationNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBoxApplicationNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxApplicationNumber.Text)) // checking if it is an empty textbox.
            {
                e.Cancel = true;
                textBoxApplicationNumber.Focus();
                FutureTenantFormErrorProvider.SetError(textBoxApplicationNumber, "Please enter application number"); 
            }
            else
            {
                e.Cancel = false;
                FutureTenantFormErrorProvider.SetError(textBoxApplicationNumber, null);

            }
        }

        private void textBoxFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFirstName.Text)) // checking firstName field is empty or not.
            {
                e.Cancel = true;
                textBoxFirstName.Focus();
                FutureTenantFormErrorProvider.SetError(textBoxFirstName, "Please enter first name");
            }
            else
            {
                e.Cancel = false;
                FutureTenantFormErrorProvider.SetError(textBoxFirstName, null);

            }
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLastName.Text)) // checking for lastname.
            {
                e.Cancel = true;
                textBoxLastName.Focus();
                FutureTenantFormErrorProvider.SetError(textBoxLastName, "Please enter last name");
            }
            else
            {
                e.Cancel = false;
                FutureTenantFormErrorProvider.SetError(textBoxLastName, null);

            }
        }

        private void textBoxLast4DigitsSSN_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLast4DigitsSSN.Text)) // for last4 digits of ssn.
            {
                e.Cancel = true;
                textBoxLast4DigitsSSN.Focus();
                FutureTenantFormErrorProvider.SetError(textBoxLast4DigitsSSN, "Please enter last 4 digit ssn");
            }
            else
            {
                e.Cancel = false;
                FutureTenantFormErrorProvider.SetError(textBoxLast4DigitsSSN, null);

            }
        }

        private void textBoxNumberOfResidents_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNumberOfResidents.Text)) // checking for numberofresidents.
            {
                e.Cancel = true;
                textBoxNumberOfResidents.Focus();
                FutureTenantFormErrorProvider.SetError(textBoxNumberOfResidents, "Please enter number of residents");
            }
            else
            {
                e.Cancel = false;
                FutureTenantFormErrorProvider.SetError(textBoxNumberOfResidents, null);

            }
        }

        private void textBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
            
        }

        private void textBoxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar); 
        }

        private void FutureTenantApplicationForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxApplicationNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
