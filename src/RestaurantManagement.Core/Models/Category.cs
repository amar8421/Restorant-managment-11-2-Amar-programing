using System;

namespace RestaurantManagement.Core.Models
{
    /// <summary>
    /// Modeli i kategorisë (p.sh: Meshkatjellesa, Peshk, Salata, etj)
    /// </summary>
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
