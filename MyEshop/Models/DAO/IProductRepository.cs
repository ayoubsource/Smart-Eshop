using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyEshop.Models.Entities;

namespace MyEshop.Models.DAO
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Create(Product product);
        void Update(Product oldProduct, Product newProduct);
        void Delete(Product product);
    }

    public class ProductManager : IProductRepository
    {
        private readonly SmartEshopDbContext _smartEshopDbContext;

        public ProductManager(SmartEshopDbContext smartEshopDbContext)
        {
            _smartEshopDbContext = smartEshopDbContext;
        }
        
        public IEnumerable<Product> GetAll()
        {
            return _smartEshopDbContext.Product;
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Create(Product product)
        {
            throw new NotImplementedException();
        }

        public void Update(Product oldProduct, Product newProduct)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
