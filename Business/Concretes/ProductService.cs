using Domain.Entity;
using EntityFramework.Repository.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using verisoftAPI.Business.Abstracts;

namespace verisoftAPI.Business.Concretes
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> repository;
        private readonly IUnitOfWork unitOfWork;

        public ProductService(IRepository<Product> repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        public void addProduct(Product product)
        {

            repository.Add(product);
            unitOfWork.Commit();
        }

        public List<Product> getAllProducts()
        {
            return repository.Get().ToList();
        }

        public Product getProduct(int id)
        {
            return repository.Get().Where(x => x.Id == id).SingleOrDefault();
        }

        public void updateProduct(Product product)
        {
            try
            {
                if (product == null)
                {
                    throw new ArgumentNullException();
                }
                repository.Update(product);
                unitOfWork.Commit();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
