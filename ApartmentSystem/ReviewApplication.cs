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

namespace ApartmentSystem
{
    public partial class ReviewApplication : Form
    {
        
        public ReviewApplication()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
         
        }

        private void ReviewApplication_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'apartmentDBDataSet.Tenant' table. You can move, or remove it, as needed.
            this.tenantTableAdapter.Fill(this.apartmentDBDataSet.Tenant);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

     

        private void submitToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tenantTableAdapter.Submit(this.apartmentDBDataSet.Tenant, ((int)(System.Convert.ChangeType(tenantIDToolStripTextBox1.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void tenantIDToolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
