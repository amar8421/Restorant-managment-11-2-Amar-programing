using RestaurantManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantManagement.Data.Repositories
{
    /// <summary>
    /// Depozita për Përdoruesit
    /// </summary>
    public class UserRepository : IRepository<User>
    {
        private DatabaseContext _context;

        public UserRepository(DatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetAll()
        {
            var users = new List<User>();
            var dataTable = _context.ExecuteQuery("SELECT * FROM Users WHERE Status = 1");

            foreach (DataRow row in dataTable.Rows)
            {
                users.Add(MapUser(row));
            }
            return users;
        }

        public User GetById(int id)
        {
            var parameters = new SqlParameter[] { new SqlParameter("@UserId", id) };
            var dataTable = _context.ExecuteQuery("SELECT * FROM Users WHERE UserId = @UserId", parameters);
            
            if (dataTable.Rows.Count > 0)
            {
                return MapUser(dataTable.Rows[0]);
            }
            return null;
        }

        public User GetByUsername(string username)
        {
            var parameters = new SqlParameter[] { new SqlParameter("@Username", username) };
            var dataTable = _context.ExecuteQuery("SELECT * FROM Users WHERE Username = @Username", parameters);
            
            if (dataTable.Rows.Count > 0)
            {
                return MapUser(dataTable.Rows[0]);
            }
            return null;
        }

        public User GetByNFC(string nfcId)
        {
            var parameters = new SqlParameter[] { new SqlParameter("@NFCID", nfcId) };
            var dataTable = _context.ExecuteQuery("SELECT * FROM Users WHERE NFCID = @NFCID AND Status = 1", parameters);
            
            if (dataTable.Rows.Count > 0)
            {
                return MapUser(dataTable.Rows[0]);
            }
            return null;
        }

        public void Add(User entity)
        {
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", entity.Username),
                new SqlParameter("@Password", entity.Password),
                new SqlParameter("@FirstName", entity.FirstName ?? ""),
                new SqlParameter("@LastName", entity.LastName ?? ""),
                new SqlParameter("@Email", entity.Email ?? ""),
                new SqlParameter("@PhoneNumber", entity.PhoneNumber ?? ""),
                new SqlParameter("@Role", entity.Role),
                new SqlParameter("@NFCID", entity.NFCID ?? (object)DBNull.Value)
            };

            string query = @"INSERT INTO Users (Username, Password, FirstName, LastName, Email, PhoneNumber, Role, Status, CreatedDate, NFCID)
                           VALUES (@Username, @Password, @FirstName, @LastName, @Email, @PhoneNumber, @Role, 1, GETDATE(), @NFCID)";

            _context.ExecuteNonQuery(query, parameters);
        }

        public void Update(User entity)
        {
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@UserId", entity.UserId),
                new SqlParameter("@FirstName", entity.FirstName ?? ""),
                new SqlParameter("@LastName", entity.LastName ?? ""),
                new SqlParameter("@Email", entity.Email ?? ""),
                new SqlParameter("@PhoneNumber", entity.PhoneNumber ?? ""),
                new SqlParameter("@Role", entity.Role),
                new SqlParameter("@NFCID", entity.NFCID ?? (object)DBNull.Value)
            };

            string query = @"UPDATE Users SET FirstName = @FirstName, LastName = @LastName, Email = @Email, 
                           PhoneNumber = @PhoneNumber, Role = @Role, NFCID = @NFCID
                           WHERE UserId = @UserId";

            _context.ExecuteNonQuery(query, parameters);
        }

        public void Delete(int id)
        {
            var parameters = new SqlParameter[] { new SqlParameter("@UserId", id) };
            string query = "UPDATE Users SET Status = 0 WHERE UserId = @UserId";
            _context.ExecuteNonQuery(query, parameters);
        }

        public void Save()
        {
            // Në këtë rast, nuk ka nevojë pasi kemi ekzekutuar direkt
        }

        private User MapUser(DataRow row)
        {
            return new User
            {
                UserId = (int)row["UserId"],
                Username = row["Username"].ToString(),
                Password = row["Password"].ToString(),
                FirstName = row["FirstName"] != DBNull.Value ? row["FirstName"].ToString() : "",
                LastName = row["LastName"] != DBNull.Value ? row["LastName"].ToString() : "",
                Email = row["Email"] != DBNull.Value ? row["Email"].ToString() : "",
                PhoneNumber = row["PhoneNumber"] != DBNull.Value ? row["PhoneNumber"].ToString() : "",
                Role = (int)row["Role"],
                Status = (int)row["Status"],
                CreatedDate = (DateTime)row["CreatedDate"],
                NFCID = row["NFCID"] != DBNull.Value ? row["NFCID"].ToString() : ""
            };
        }
    }
}
