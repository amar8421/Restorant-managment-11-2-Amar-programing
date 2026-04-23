using System;

namespace RestaurantManagement.Core.Models
{
    /// <summary>
    /// Modeli i artikullit në porosi
    /// </summary>
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TaxPercentage { get; set; }
        public decimal LineTotal { get; set; }
        public int Status { get; set; }  // OrderItemStatus enum
        public string Notes { get; set; }
        public DateTime CreatedDate { get; set; }

        // Navigation properties
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }

        public string StatusText
        {
            get
            {
                return Status switch
                {
                    1 => "Në pritje",
                    2 => "Në gatim",
                    3 => "E gatshme",
                    4 => "E shërbyer",
                    _ => "I panjohur"
                };
            }
        }
    }
}
