using RestaurantManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantManagement.Data.Repositories
{
    /// <summary>
    /// Depozita për Porosite
    /// </summary>
    public class OrderRepository : IRepository<Order>
    {
        private DatabaseContext _context;

        public OrderRepository(DatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Order> GetAll()
        {
            var orders = new List<Order>();
            var dataTable = _context.ExecuteQuery("SELECT * FROM Orders ORDER BY OrderDate DESC");

            foreach (DataRow row in dataTable.Rows)
            {
                orders.Add(MapOrder(row));
            }
            return orders;
        }

        public Order GetById(int id)
        {
            var parameters = new SqlParameter[] { new SqlParameter("@OrderId", id) };
            var dataTable = _context.ExecuteQuery("SELECT * FROM Orders WHERE OrderId = @OrderId", parameters);
            
            if (dataTable.Rows.Count > 0)
            {
                return MapOrder(dataTable.Rows[0]);
            }
            return null;
        }

        public void Add(Order entity)
        {
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderNumber", entity.OrderNumber),
                new SqlParameter("@TableId", entity.TableId),
                new SqlParameter("@WaiterId", entity.WaiterId),
                new SqlParameter("@Status", entity.Status),
                new SqlParameter("@Notes", entity.Notes ?? ""),
                new SqlParameter("@SubTotal", entity.SubTotal),
                new SqlParameter("@TaxAmount", entity.TaxAmount),
                new SqlParameter("@Total", entity.Total)
            };

            string query = @"INSERT INTO Orders (OrderNumber, TableId, WaiterId, OrderDate, Status, Notes, SubTotal, TaxAmount, Total)
                           VALUES (@OrderNumber, @TableId, @WaiterId, GETDATE(), @Status, @Notes, @SubTotal, @TaxAmount, @Total)";

            _context.ExecuteNonQuery(query, parameters);
        }

        public void Update(Order entity)
        {
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderId", entity.OrderId),
                new SqlParameter("@Status", entity.Status),
                new SqlParameter("@Notes", entity.Notes ?? ""),
                new SqlParameter("@SubTotal", entity.SubTotal),
                new SqlParameter("@TaxAmount", entity.TaxAmount),
                new SqlParameter("@Total", entity.Total),
                new SqlParameter("@CompletedDate", entity.CompletedDate ?? (object)DBNull.Value)
            };

            string query = @"UPDATE Orders SET Status = @Status, Notes = @Notes, SubTotal = @SubTotal, 
                           TaxAmount = @TaxAmount, Total = @Total, CompletedDate = @CompletedDate
                           WHERE OrderId = @OrderId";

            _context.ExecuteNonQuery(query, parameters);
        }

        public void Delete(int id)
        {
            var parameters = new SqlParameter[] { new SqlParameter("@OrderId", id) };
            string query = "UPDATE Orders SET Status = 5 WHERE OrderId = @OrderId";  // 5 = Cancelled
            _context.ExecuteNonQuery(query, parameters);
        }

        public void Save()
        {
            // Në këtë rast, nuk ka nevojë pasi kemi ekzekutuar direkt
        }

        private Order MapOrder(DataRow row)
        {
            return new Order
            {
                OrderId = (int)row["OrderId"],
                OrderNumber = row["OrderNumber"].ToString(),
                TableId = (int)row["TableId"],
                WaiterId = (int)row["WaiterId"],
                OrderDate = (DateTime)row["OrderDate"],
                Status = (int)row["Status"],
                Notes = row["Notes"] != DBNull.Value ? row["Notes"].ToString() : "",
                SubTotal = (decimal)row["SubTotal"],
                TaxAmount = (decimal)row["TaxAmount"],
                Total = (decimal)row["Total"]
            };
        }
    }
}
