using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IProductService
    {
        List<Product> getAllProducts();

        void addProduct(Product product);

        Product getProduct(int id);

        void updateProduct(Product product);
    }
}
