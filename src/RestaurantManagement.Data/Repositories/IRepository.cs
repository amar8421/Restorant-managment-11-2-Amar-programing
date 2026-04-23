using System;
using System.Collections.Generic;
using System.Data;

namespace RestaurantManagement.Data.Repositories
{
    /// <summary>
    /// Interface për bazën e operacioneve të depozitës
    /// </summary>
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        void Save();
    }
}
