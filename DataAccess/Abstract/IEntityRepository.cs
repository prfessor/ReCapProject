using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class, IEntity, new()

    {
        List<T> GetAll();        
        void Add(T carEntity);
        void Update(T carEntity);
        void Delete(T carEntity);
        List<T> GetById(int id);
        List<T> GetByDailyPrice(decimal min, decimal max);
        List<T> GetByModelYear(int modelYear);

        





    }
}
