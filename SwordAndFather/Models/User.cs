using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwordAndFather.Models
{
    public class User
    {
        //Properties
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        //Constructor
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}