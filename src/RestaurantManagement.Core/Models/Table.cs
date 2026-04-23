using System;

namespace RestaurantManagement.Core.Models
{
    /// <summary>
    /// Modeli i tavolina në restorant
    /// </summary>
    public class Table
    {
        public int TableId { get; set; }
        public int TableNumber { get; set; }
        public int Capacity { get; set; }
        public int Status { get; set; }  // 1=Available, 2=Occupied, 3=Reserved
        public string Location { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }

        public string StatusText
        {
            get
            {
                return Status switch
                {
                    1 => "E lirë",
                    2 => "Zënë",
                    3 => "E rezervuar",
                    _ => "I panjohur"
                };
            }
        }
    }
}
