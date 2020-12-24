using System;
using System.Collections.Generic;
using System.Text;

namespace Anti_Corona.Data.Abstract
{
    public interface IRepository<T>
    {
        T GetById(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
