using System;
using System.Collections.Generic;

namespace RestaurantManagement.Core.Models
{
    /// <summary>
    /// Modeli i porosise
    /// </summary>
    public class Order
    {
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public int TableId { get; set; }
        public int WaiterId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public int Status { get; set; }  // OrderStatus enum
        public string Notes { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal Total { get; set; }

        // Navigation properties
        public virtual Table Table { get; set; }
        public virtual User Waiter { get; set; }
        public virtual List<OrderItem> OrderItems { get; set; }

        public string StatusText
        {
            get
            {
                return Status switch
                {
                    1 => "E re",
                    2 => "Duke u përpunuar",
                    3 => "E gatshme",
                    4 => "Përfunduar",
                    5 => "Anuluar",
                    _ => "I panjohur"
                };
            }
        }
    }
}
