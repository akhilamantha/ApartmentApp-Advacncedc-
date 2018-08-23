using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentSystem.DAL
{
    public class AvailabilityDetails
    {
        public string GetSinglebedRoomDetails()
        {

            SingleBedroom _roomqualities = new SingleBedroom // class singlebedrooms's object is created and called by using Bind function.
            {
                NumberOfAparmentsAvailabilty = 16, //here we give direct values to variables in order to implement inheritance and polymorphism.
                Cost = 600.00m,
                IsPrefriendly = false,
                Facing = "East"
            };
            return BindSingleBedRoomDetails(_roomqualities);
        }
        public string BindSingleBedRoomDetails(SingleBedroom _roomqualities)
        {
            return $"Number of apartments Availabilty : " + _roomqualities.NumberOfAparmentsAvailabilty + Environment.NewLine +
                "Cost of Unit :" + _roomqualities.Cost.ToString("C") + Environment.NewLine + // here c stands for current i.e $(dollar) Tostring inorder to covert int to string .
                "Is Pet Friendly:" + _roomqualities.IsPrefriendly + Environment.NewLine +
                "Unit Facing :" + _roomqualities.Facing;
        }
        public string GetDoubleBedRoomDetails() //same as single bedroom.
        {
            DoubleBedroom dblbedroom = new DoubleBedroom
            {
                NumberOfAparmentsAvailabilty = 16,
                Cost = 800.00m,
                IsPrefriendly = false,
                Facing = "East"
            };
            return BindDoubleBedRoomDetails(dblbedroom);
        }
        public string BindDoubleBedRoomDetails(DoubleBedroom _roomqualities)
        {
            return $"Number of apartments Availabilty : " + _roomqualities.NumberOfAparmentsAvailabilty + Environment.NewLine +
                "Cost of Unit :" + _roomqualities.Cost.ToString("C") + Environment.NewLine +
                "Is Pet Friendly:" + _roomqualities.IsPrefriendly + Environment.NewLine +
                "Unit Facing :" + _roomqualities.Facing;
        }
        public string GetTripplebedRoomDetails()
        {
            TripleBedRoom triplebedroomdetails = new TripleBedRoom
            {
                NumberOfAparmentsAvailabilty = 12,
                Cost = 1200.00m,
                IsPrefriendly = false,
                Facing = "WEst"
            };
            return BindtripleBedRoomDetails(triplebedroomdetails);
        }
        public string BindtripleBedRoomDetails(TripleBedRoom _roomqualities)
        {
            return $"Number of apartments Availabilty : " + _roomqualities.NumberOfAparmentsAvailabilty + Environment.NewLine +
                "Cost of Unit :" + _roomqualities.Cost.ToString("C") + Environment.NewLine +
                "Is Pet Friendly:" + _roomqualities.IsPrefriendly + Environment.NewLine +
                "Unit Facing :" + _roomqualities.Facing;
        }

        public string GetStudioRoomDetails()
        {
            StudioRoom studioroomDetails= new StudioRoom
            {
                NumberOfAparmentsAvailabilty = 3,
                Cost = 600.00M,
                IsPrefriendly = false,
                Facing = "North"
            };

           return   BindstudionRoomDetails(studioroomDetails);

        }
        public string BindstudionRoomDetails(StudioRoom _roomqualities)
        {
            return $"Number of apartments Availabilty : " + _roomqualities.NumberOfAparmentsAvailabilty + Environment.NewLine +
                "Cost of Unit :" + _roomqualities.Cost.ToString("C") + Environment.NewLine +
                "Is Pet Friendly:" + _roomqualities.IsPrefriendly + Environment.NewLine +
                "Unit Facing :" + _roomqualities.Facing;
        }

    }
}
