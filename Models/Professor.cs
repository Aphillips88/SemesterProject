using cidm4390.Data;
using Microsoft.AspNetCore.Identity;


namespace cidm4390.Models
{
    public class Professor : IdentityUser
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string MobileNumber {get; set;}
        
    }
}