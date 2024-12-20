namespace Kuafor_BerberOtomasyonSistemi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; } // Nullable
        public string? Email { get; set; } // Nullable
        public string? Password { get; set; } // Nullable
        public string? Role { get; set; } // Nullable
    }
}
