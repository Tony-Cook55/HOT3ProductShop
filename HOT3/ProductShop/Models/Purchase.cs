namespace ProductShop.Models
{
    public class Purchase
    {

        // Primary Key
        public int Id { get; set; }

        // Foreign Key
        public int RecordId { get; set; }

        // Navigation Property
        public Record Record { get; set; }

        public int? Quantity { get; set; }

        public DateTime? PurchaseDate { get; set; }

        public decimal? Total { get; set; }


    }
}
