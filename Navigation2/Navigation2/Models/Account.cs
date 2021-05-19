using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Navigation2.Models
{
    public class Account
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Account(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public Account()
        {

        }
    }
}
