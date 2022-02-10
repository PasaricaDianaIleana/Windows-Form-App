using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
   public class Register
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public string Role { get; set; }
        public string City { get; set; }


        public Register(string name, string password, string email, string number, string city, string role)
        {
            UserName = name;
            Password = password;
            Email = email;
            PhoneNumber = number;
            City = city;
            Role = role;
        } 

        public Register()
        {

        }
    }
}
