using System;

namespace RestaurantManagement.Core.Models
{
    /// <summary>
    /// Modeli i përdoruesit (Admin, Kamarieri, Kuzhinari)
    /// </summary>
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int Role { get; set; }  // UserRole enum
        public int Status { get; set; }  // 1=Active, 0=Inactive
        public DateTime CreatedDate { get; set; }
        public DateTime? LastLogin { get; set; }
        public string NFCID { get; set; }  // Per NFC/RFID login

        public string FullName { get => $"{FirstName} {LastName}"; }
    }
}
