using System;
using System.Collections.Generic;
using System.Text;

namespace Testik.Models
{
    public enum Role
    {
        Client, Admin
    }
    public class User
    {
        public int Id { get; set; }
        public Role Role { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
