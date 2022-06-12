using Domain.Entity;
using EntityFramework.Repository.Abstracts;
using Microsoft.EntityFrameworkCore;

using System.Linq;


namespace EntityFramework.Repository.Concretes
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {


        public readonly IUnitOfWork unitOfWork;
        public Repository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public void Add(T entity)
        {
            unitOfWork.Context.Set<T>().Add(entity);
        }
        public void Delete(T entity)
        {

            if (entity != null)
            {

                entity.isDeleted = true;
                unitOfWork.Context.Entry(entity).State = EntityState.Modified;
            }

        }
        public IQueryable<T> Get()
        {

            return unitOfWork.Context.Set<T>().Where(x => !x.isDeleted).AsQueryable();
        }
        public void Update(T entity)
        {

            unitOfWork.Context.Entry(entity).State = EntityState.Modified;

        }
    }
}
