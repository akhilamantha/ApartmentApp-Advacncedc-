namespace ApartmentSystem
{
    public class RoomQualities // parent class for all the remaining classes i.e single, double, triple,studio.
    {
        public int NumberOfAparmentsAvailabilty { get; set; }
        public decimal Cost { get; set; }
        public bool IsPrefriendly { get; set; }
        public string Facing { get; set; }
    }

}
