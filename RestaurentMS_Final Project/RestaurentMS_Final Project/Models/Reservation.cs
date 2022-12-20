namespace RestaurentMS_Final_Project.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        public string CustomerName { get; set; }

        public string CustomerEmail { get; set; }

        public string CustomerPhone { get; set; }

        public string EventName { get; set; }

        public int NumberOfPersons { get; set; }

        public DateTime ReservationTime { get; set; }
    }
}
