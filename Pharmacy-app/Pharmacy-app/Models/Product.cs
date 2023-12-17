namespace Pharmacy_app.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? DosageForm { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public string? PhotoFile { get; set; }

        public string? Description { get; set; }
    }
}
