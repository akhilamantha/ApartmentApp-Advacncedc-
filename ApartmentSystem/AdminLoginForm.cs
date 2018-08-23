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
using ApartmentSystem.DAL;
using ApartmentSystem.DAL.Entities; //importing the classes in the entities folders of apartmentSystem DAL.
//GROUP 7
namespace ApartmentSystem
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
            
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //check username and password is empty or not
            if (string.IsNullOrEmpty(UserNameTextBox.Text) || string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                if (string.IsNullOrEmpty(UserNameTextBox.Text))
                {
                    UserNameTextBox.Focus();
                    errorProvider1.SetError(UserNameTextBox, "Please enter username"); 
                }//end of string.IsNullOrEmpty(UserNameTextBox.Text))
                else
                {
                    PasswordTextBox.Focus();
                    errorProvider1.SetError(PasswordTextBox, "Please enter password");

                }////end of settinng password text box error
            }
            else
            {
                LoginDal logInDataAccess = new LoginDal(); //  created an object to invoke the login data access connection in the DAL.
                Login _loginDetails = new Login
                {
                    UserName = UserNameTextBox.Text,
                    PassWord = PasswordTextBox.Text
                };

                int recordsCount = logInDataAccess.GetuserDetails(_loginDetails); //this statement acts multipurpose  1)recordsCount acts as variable for checking number of rows retrived      2) for validating the entered user details 

                if (recordsCount > 0) // when the username and password matches one row will be retrived from the database so count is > 0 
                {
                    this.Hide();

                    AdminMenuForm menuFm = new AdminMenuForm();
                    menuFm.Closed += (s, args) => this.Close(); // if username and password matches by using delegate property the current form will be hidden and admin menu form is shown.
                    menuFm.Show();
                }
                else
                {
                    ErrorMessagelabel.Visible = true;
                    //MessageBox.Show("Please enter Correct Username and Password");
                   // errorProvider1.SetError(UserNameTextBox, "User Name is Invaldi");
                }
            }

        }

        private void ExitLoginButton_Click(object sender, EventArgs e)
        {
            this.Close(); // exits the adminForm.
        }

        private void UserNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(UserNameTextBox.Text)) //checking wether the textbox is empty or not.
            {
                e.Cancel = true; // here e is the event .
                UserNameTextBox.Focus();
                errorProvider1.SetError(UserNameTextBox, "Please enter username");// when username textfield is empty and on hover on the exclamation throws the above mentioned messsage.
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(UserNameTextBox, null);

            }
        }

        private void PasswordTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                e.Cancel = true;
                PasswordTextBox.Focus();
                errorProvider1.SetError(PasswordTextBox, "Please enter password");// when password textfield is empty and on hover on the exclamation throws the above mentioned messsage.
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(PasswordTextBox, null);

            }

        }

        private void AdminLoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
