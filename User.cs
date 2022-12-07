using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personal_library
{
    public class User
    {
        public enum UserType { Administrator, Reader };
        private string login;
        private string password;
        private UserType userType;
        public User(string login, string password, UserType userType)
        {
            this.login = login;
            this.password = password;
            this.userType = userType;
        }
        public string getPassword() 
        {
            return password;
        }

    }

}
