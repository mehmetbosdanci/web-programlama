namespace Kuafor_BerberOtomasyonSistemi.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public bool IsAvailable { get; set; } // Müsaitlik durumu
    }
}
