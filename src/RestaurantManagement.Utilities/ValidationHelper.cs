using System;
using System.Text.RegularExpressions;

namespace RestaurantManagement.Utilities
{
    /// <summary>
    /// Ndihmues për validimin e të dhënave
    /// </summary>
    public static class ValidationHelper
    {
        /// <summary>
        /// Kontrolloni nëse emaili është valid
        /// </summary>
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Kontrolloni nëse numri i telefonit është valid
        /// </summary>
        public static bool IsValidPhoneNumber(string phone)
        {
            if (string.IsNullOrEmpty(phone))
                return false;

            // Shënim simple - vetëm numra dhe "+", min 9 karaktere
            return Regex.IsMatch(phone, @"^[\d\+\-\(\)\s]{9,}$");
        }

        /// <summary>
        /// Kontrolloni nëse stringi është bosh ose null
        /// </summary>
        public static bool IsNullOrEmpty(string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        /// <summary>
        /// Kontrolloni nëse çmimi është valid
        /// </summary>
        public static bool IsValidPrice(decimal price)
        {
            return price > 0;
        }

        /// <summary>
        /// Kontrolloni nëse përqindja është valid (0-100)
        /// </summary>
        public static bool IsValidPercentage(decimal percentage)
        {
            return percentage >= 0 && percentage <= 100;
        }
    }
}
