using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TRUCK.Core.Entity;

namespace TRUCK.Core.Service
{
        public interface ICoreService<T> where T : CoreEntity
        {
            
            bool Add(T item); 
            bool Delete(int id); 
            bool Update(T item); 
            T GetByID(int id); 
            T GetRecord(Expression<Func<T, bool>> expression); 
            List<T> GetAll();
        List<T> GetAllAsync(params Expression<Func<T, object>>[] includeProperties);
            int Save(); 
        }
    
}
