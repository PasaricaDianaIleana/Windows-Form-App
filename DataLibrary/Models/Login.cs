using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
   public class Login
    {

        public string UserName { get; set; }
        public string Password { get; set; }

        public string UserRole { get; set; }


        public Login()
        {

        }
        public Login(string Username,string password, string role) : this() 
        {
            UserName=Username;
            Password = password;
            UserRole=role;

        }
    }
}
