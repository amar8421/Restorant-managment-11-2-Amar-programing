using System;

namespace RestaurantManagement.Core.Models
{
    /// <summary>
    /// Modeli i produktit (p.sh: Mish Viçi por 8.50€, etj)
    /// </summary>
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal TaxPercentage { get; set; }  // TVSH
        public int Quantity { get; set; }  // Sasia në inventar
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        // Helper methods
        public decimal PriceWithTax { get => Price * (1 + TaxPercentage / 100); }
        public decimal TaxAmount { get => Price * TaxPercentage / 100; }
    }
}
