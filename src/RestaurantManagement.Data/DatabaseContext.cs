using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace RestaurantManagement.Data
{
    /// <summary>
    /// Klasa për lidhjen me bazën e të dhënave
    /// </summary>
    public class DatabaseContext
    {
        private string _connectionString;

        public DatabaseContext()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"]?.ConnectionString 
                ?? "Server=(localdb)\\mssqllocaldb;Database=RestaurantDB;Trusted_Connection=true;";
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        /// <summary>
        /// Lexo të dhënat direkt nga baza
        /// </summary>
        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        /// <summary>
        /// Ekzekuto procedurë ose komandë që nuk kthen re sultat
        /// </summary>
        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Ekzekuto procedurë dhe marrë skalarin
        /// </summary>
        public object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    return cmd.ExecuteScalar();
                }
            }
        }
    }
}
