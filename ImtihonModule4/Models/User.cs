namespace ImtihonModule4.Models
{
    public class User
    {
        public User(string username, string password, string phone)
        {
            this.username = username;
            this.password = password;
            this.phone = phone;

        }

        public User(int id, string username, string password, string phone, Role role)
        {
            Id = id;
            this.username = username;
            this.password = password;
            this.phone = phone;
            this.role = role;
        }

        public int Id { get; set; }
        string username { get; set; }   
        public string password { get; set; }
        public string phone { get; set; }
        public Role role { get; set; }
    }
    public enum  Role
    {
        Company = 1,
        User = 2,

    }
}
