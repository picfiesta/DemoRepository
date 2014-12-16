using DemoRepository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DemoRepository.Data
{
    public interface IRepositoryBase<T> where T : BaseEntity
    {
        void Delete(T entity);
        T GetById(object id);
        void Insert(T entity);
        System.Linq.IQueryable<T> Table { get; }
        void Update(T entity);
    }
}
