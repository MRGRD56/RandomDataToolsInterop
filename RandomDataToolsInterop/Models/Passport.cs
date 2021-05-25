using System;

namespace RandomDataToolsInterop.Models
{
    public class Passport
    {
        public string Series { get; set; }
        
        public string Number { get; set; }
        
        public string FullNumber { get; set; }
        
        public string LivingAddress { get; set; }
        
        public string RegistrationAddress { get; set; }
        
        public string Country { get; set; }
        
        public string Region { get; set; }

        public string City { get; set; }
        
        public string Street { get; set; }
        
        public int House { get; set; }
        
        public int Apartment { get; set; }
        
        public string Code { get; set; }
        
        public string IssuedBy { get; set; }
        
        public DateTime IssueDate { get; set; }
    }
}