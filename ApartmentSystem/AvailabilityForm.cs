using ApartmentSystem.DAL;
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
    public partial class AvailabilityForm : Form
    {
        public AvailabilityForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void AvailabilityForm_Load(object sender, EventArgs e)
        {

        }
        private void StudioButton_Click(object sender, EventArgs e)
        {

            AvailabilityDetails obj = new AvailabilityDetails();
            textBoxRoomDetails.Text=obj.GetStudioRoomDetails();


        }
        private void DoubleBedroomButton_Click(object sender, EventArgs e)
        {
            //DoubleBedroom _roomqualities = new DoubleBedroom();
            //BinddoubleRoomDetails(_roomqualities);

            AvailabilityDetails obj = new AvailabilityDetails();
            textBoxRoomDetails.Text = obj.GetDoubleBedRoomDetails();
        }
        private void SingleBedroomButton_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            //SingleBedroom _roomqualities = new SingleBedroom();
            //BindSingleBedRoomDetails(_roomqualities);
            AvailabilityDetails obj = new AvailabilityDetails();
            textBoxRoomDetails.Text = obj.GetSinglebedRoomDetails();
        }
        private void TripleBedRoomButton_Click(object sender, EventArgs e)
        {

            //TripleBedRoom  _roomqualities = new TripleBedRoom();
            //BindTripleBedRoomDetails(_roomqualities);

            AvailabilityDetails availablaitydetails = new AvailabilityDetails();
            textBoxRoomDetails.Text = availablaitydetails.GetTripplebedRoomDetails();



        }
    }
}
