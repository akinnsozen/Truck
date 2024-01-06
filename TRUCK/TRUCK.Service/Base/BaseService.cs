using TRUCK.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TRUCK.Core.Entity;
using TRUCK.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace TRUCK.Service.Base
{
    public class BaseService<T> : ICoreService<T> where T : CoreEntity
    {
        private readonly TRUCKContext _db;

        public BaseService(TRUCKContext db)
        {
            _db = db;
        }

        public bool Add(T item)
        {
            try
            {
                _db.Set<T>().Add(item);
                return Save() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                _db.Set<T>().Remove(GetByID(id));
                return Save() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<T> GetAll() => _db.Set<T>().ToList();


        public List<T> GetAllAsync(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _db.Set<T>();
           
            if (includeProperties.Any())
                foreach (var item in includeProperties)
                {
                    query = query.Include(item);
                }
            return  query.ToList();

        }

            public T GetByID(int id) => _db.Set<T>().Find(id);

        public T GetRecord(Expression<Func<T, bool>> expression)
        {
            return _db.Set<T>().FirstOrDefault(expression);
        }

        public int Save()
        {
            return _db.SaveChanges();
        }

        public bool Update(T item)
        {
            try
            {
                _db.Set<T>().Update(item);
                return Save() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
