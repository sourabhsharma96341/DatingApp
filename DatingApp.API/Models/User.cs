namespace DatingApp.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswardHash { get; set; }
        public byte[] PasswardSalt { get; set; }

    }
}