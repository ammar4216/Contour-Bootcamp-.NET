namespace RestaurentMS_Final_Project.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string CNIC { get; set; }

        public long ContactNo { get; set; }

        public int AddressId { get; set; }

        public int RoleId { get; set; }

        public Address address { get; set; }

        public Roles roles { get; set; }


    }
}
