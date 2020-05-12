namespace Store.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Product
    {
        [Key]
        public int ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime LastPurchase { get; set; }
        public float Stocks { get; set; }
    }
}