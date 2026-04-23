using RestaurantManagement.Core.Models;
using RestaurantManagement.Data;
using RestaurantManagement.Data.Repositories;

namespace RestaurantManagement.Core.Services
{
    /// <summary>
    /// Shërbimi i autentifikimit
    /// </summary>
    public class AuthService
    {
        private UserRepository _userRepository;

        public AuthService()
        {
            var context = new DatabaseContext();
            _userRepository = new UserRepository(context);
        }

        /// <summary>
        /// Kontrollo kredencialet e përdoruesit
        /// </summary>
        public User Login(string username, string password)
        {
            var user = _userRepository.GetByUsername(username);
            
            if (user != null && user.Status == 1 && VerifyPassword(password, user.Password))
            {
                return user;
            }
            
            return null;
        }

        /// <summary>
        /// Login me NFC/RFID chip
        /// </summary>
        public User LoginWithNFC(string nfcId)
        {
            var user = _userRepository.GetByNFC(nfcId);
            return user;
        }

        /// <summary>
        /// Verifikimi i fjalëkalimit (thjeshtë për tani)
        /// </summary>
        private bool VerifyPassword(string inputPassword, string storedPassword)
        {
            // Në një aplikacion real, do të përdorni hashing (p.sh. BCrypt)
            // Për tani, krahasim thjesht
            return inputPassword == storedPassword;
        }

        /// <summary>
        /// Regjistrimi i përdoruesit të ri
        /// </summary>
        public bool Register(User user)
        {
            try
            {
                _userRepository.Add(user);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Ndryshimi i fjalëkalimit
        /// </summary>
        public bool ChangePassword(int userId, string oldPassword, string newPassword)
        {
            var user = _userRepository.GetById(userId);
            
            if (user != null && VerifyPassword(oldPassword, user.Password))
            {
                user.Password = newPassword;
                _userRepository.Update(user);
                return true;
            }
            
            return false;
        }
    }
}
