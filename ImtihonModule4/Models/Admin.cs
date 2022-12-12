namespace ImtihonModule4.Models
{
    public class Admin
    {
        public Admin(string username, string password, string phone)
        {
            this.username = username;
            this.password = password;
            this.phone = phone;
        }

        public Admin(int id, string username, string password, string phone)
        {
            Id = id;
            this.username = username;
            this.password = password;
            this.phone = phone;
        }

        public int Id { get; set; }
        string username { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
    }
}
