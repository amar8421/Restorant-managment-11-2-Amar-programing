using System;

namespace RestaurantManagement.Core.Models
{
    /// <summary>
    /// Modeli i faturës
    /// </summary>
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public int OrderId { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal Total { get; set; }
        public string PaymentMethod { get; set; }
        public int PaymentStatus { get; set; }  // 1=Pending, 2=Paid, 3=Partially Paid
        public string Notes { get; set; }
        public string BarcodeData { get; set; }

        // Navigation properties
        public virtual Order Order { get; set; }

        public string PaymentStatusText
        {
            get
            {
                return PaymentStatus switch
                {
                    1 => "Në pritje",
                    2 => "Paguar",
                    3 => "Pjesërisht paguar",
                    _ => "I panjohur"
                };
            }
        }
    }
}
