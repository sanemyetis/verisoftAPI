using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Repository.Abstracts
{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> Get();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
