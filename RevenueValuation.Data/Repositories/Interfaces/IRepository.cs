using System;
using System.Collections.Generic;
using System.Text;

namespace RevenueValuation.Data.Repositories.Interfaces
{
    public interface IRepository<T> 
    {
        List<T> GetAll();
        T GetById(int id);
        bool Insert(T item);
        bool InsertMultiple(List<T> items);
    }
}
