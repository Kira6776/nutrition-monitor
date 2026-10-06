using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prpr1.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; } = "User";

        public User() { }

        public User(string login, string passwordHash, string role = "User")
        {
            Login = login;
            PasswordHash = passwordHash;
            Role = role;
        }
    }
}
