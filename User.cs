using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalLibrary.Models
{
    public class User
    {
        public enum UserType { Administrator, Reader };
        public string login { get; set; }
        public string password { get; set; }
        public UserType userType { get; set; }
        public User(string login, string password, UserType userType)
        {
            this.login = login;
            this.password = password;
            this.userType = userType;
        }

    }

}
