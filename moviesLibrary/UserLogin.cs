using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moviesLibrary
{
    public class UserLoginModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class UserRegisterModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public UserRole Role { get; set; }
    }
}
