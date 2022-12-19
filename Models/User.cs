namespace PersonalLibrary.Models
{
    public class User
    {
        public enum UserType { Administrator, Reader };
        public string Login { get; set; }
        public string Password { get; set; }
        public UserType Type { get; set; }
        public User(string login, string password, UserType userType)
        {
            this.Login = login;
            this.Password = password;
            this.Type = userType;
        }

    }

}
