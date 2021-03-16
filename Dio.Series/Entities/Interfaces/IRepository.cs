using System;
using System.Collections.Generic;
using System.Text;

namespace Dio.Series.Entities.Interfaces
{
    public interface IRepository<T>
    {
        List<T> List();
        T ReturnById(int id);
        void Create(T entity);
        void Delete(int id);
        void Update(int id, T entity);
        int NextId();
    }
}
