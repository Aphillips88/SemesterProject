using Microsoft.AspNetCore.Identity;

namespace cidm4390.Models
{
    public class AdminUser : IdentityUser //default class responsible for storing username timestamps etc
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string MobileNumber {get; set;}
    }
}