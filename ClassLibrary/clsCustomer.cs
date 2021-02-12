using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string Flat { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }
    }
}