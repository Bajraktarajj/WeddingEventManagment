namespace Domain.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Password { get; set; } // Shto për login

        public override string ToString()
        {
            return $"ID: {UserID}, Name: {Name}, Email: {Email}, Role: {Role}";
        }
    }
}
