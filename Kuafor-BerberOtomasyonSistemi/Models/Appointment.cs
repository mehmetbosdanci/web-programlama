namespace Kuafor_BerberOtomasyonSistemi.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } // İlişki
        public DateTime Date { get; set; }
        public string Service { get; set; }
        public decimal Price { get; set; }
    }
}
