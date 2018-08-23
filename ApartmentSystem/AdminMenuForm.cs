using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentSystem
{
    public partial class AdminMenuForm : Form
    {
        public AdminMenuForm()
        {
            InitializeComponent();
        }

        private void GoBackAdminMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLoginForm loginForm = new AdminLoginForm();
            loginForm.Closed += (s, args) => this.Close(); // when clicking goback button the adminmenuForm closes and goes back to adminLoginForm again using delegate property.
            loginForm.Show();
        }

        private void FutureTenantApplicationButton_Click(object sender, EventArgs e)
        {
            FutureTenantApplicationForm FutureTenant = new FutureTenantApplicationForm();
            FutureTenant.Show(); // on clicking FutureTenantApplication button shows us FutureTenantForm as current Form.
        }

        private void ReviewFormButton_Click(object sender, EventArgs e)
        {
            ReviewApplication reviewApp = new ReviewApplication();
            reviewApp.Show(); // on clicking review button presents us the review form.
        }

        private void AvailabilityButton_Click(object sender, EventArgs e)
        {
            AvailabilityForm availForm = new AvailabilityForm();
            availForm.Show();// on clicking the availability  button shows us the availability form.
        }

        private void ExitAdminMenuButton_Click(object sender, EventArgs e)
        {
            this.Close(); //exits the FutureTenantApplication form
        }

        private void AdminMenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
