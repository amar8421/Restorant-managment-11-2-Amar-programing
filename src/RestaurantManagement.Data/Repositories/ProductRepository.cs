using RestaurantManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantManagement.Data.Repositories
{
    /// <summary>
    /// Depozita për Produktet
    /// </summary>
    public class ProductRepository : IRepository<Product>
    {
        private DatabaseContext _context;

        public ProductRepository(DatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAll()
        {
            var products = new List<Product>();
            var dataTable = _context.ExecuteQuery("SELECT * FROM Products WHERE IsActive = 1 ORDER BY CategoryId");

            foreach (DataRow row in dataTable.Rows)
            {
                products.Add(MapProduct(row));
            }
            return products;
        }

        public Product GetById(int id)
        {
            var parameters = new SqlParameter[] { new SqlParameter("@ProductId", id) };
            var dataTable = _context.ExecuteQuery("SELECT * FROM Products WHERE ProductId = @ProductId", parameters);
            
            if (dataTable.Rows.Count > 0)
            {
                return MapProduct(dataTable.Rows[0]);
            }
            return null;
        }

        public void Add(Product entity)
        {
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@ProductName", entity.ProductName),
                new SqlParameter("@CategoryId", entity.CategoryId),
                new SqlParameter("@Description", entity.Description ?? ""),
                new SqlParameter("@Price", entity.Price),
                new SqlParameter("@TaxPercentage", entity.TaxPercentage),
                new SqlParameter("@Quantity", entity.Quantity),
                new SqlParameter("@IsActive", entity.IsActive)
            };

            string query = @"INSERT INTO Products (ProductName, CategoryId, Description, Price, TaxPercentage, Quantity, IsActive, CreatedDate)
                           VALUES (@ProductName, @CategoryId, @Description, @Price, @TaxPercentage, @Quantity, @IsActive, GETDATE())";

            _context.ExecuteNonQuery(query, parameters);
        }

        public void Update(Product entity)
        {
            var parameters = new SqlParameter[]
            {
                new SqlParameter("@ProductId", entity.ProductId),
                new SqlParameter("@ProductName", entity.ProductName),
                new SqlParameter("@CategoryId", entity.CategoryId),
                new SqlParameter("@Description", entity.Description ?? ""),
                new SqlParameter("@Price", entity.Price),
                new SqlParameter("@TaxPercentage", entity.TaxPercentage),
                new SqlParameter("@Quantity", entity.Quantity),
                new SqlParameter("@IsActive", entity.IsActive)
            };

            string query = @"UPDATE Products SET ProductName = @ProductName, CategoryId = @CategoryId, Description = @Description,
                           Price = @Price, TaxPercentage = @TaxPercentage, Quantity = @Quantity, IsActive = @IsActive, ModifiedDate = GETDATE()
                           WHERE ProductId = @ProductId";

            _context.ExecuteNonQuery(query, parameters);
        }

        public void Delete(int id)
        {
            var parameters = new SqlParameter[] { new SqlParameter("@ProductId", id) };
            string query = "UPDATE Products SET IsActive = 0 WHERE ProductId = @ProductId";
            _context.ExecuteNonQuery(query, parameters);
        }

        public void Save()
        {
            // Në këtë rast, nuk ka nevojë pasi kemi ekzekutuar direkt
        }

        private Product MapProduct(DataRow row)
        {
            return new Product
            {
                ProductId = (int)row["ProductId"],
                ProductName = row["ProductName"].ToString(),
                CategoryId = (int)row["CategoryId"],
                Description = row["Description"].ToString(),
                Price = (decimal)row["Price"],
                TaxPercentage = (decimal)row["TaxPercentage"],
                Quantity = (int)row["Quantity"],
                IsActive = (bool)row["IsActive"],
                CreatedDate = (DateTime)row["CreatedDate"]
            };
        }
    }
}
