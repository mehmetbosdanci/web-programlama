using Microsoft.AspNetCore.Identity;

namespace Kuafor_BerberOtomasyonSistemi.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Ekstra bir özellik ekleyebilirsiniz
        public string? FullName { get; set; } // Nullable olarak ekledik
    }
}
