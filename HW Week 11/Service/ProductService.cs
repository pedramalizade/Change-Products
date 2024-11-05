using HW_Week_11.Config;
using HW_Week_11.Entitis;
using HW_Week_11.Repository;
using Microsoft.Identity.Client.Extensions.Msal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Week_11.Service
{

    public class ProductService : IProductService
    {
        private IProductRepository _repository;

        public ProductService()
        {
            _repository = new ProductRepository();
        }
        

        public void Add(string name, int? price, int? categoryId)
        {
            var product = new Product();
            product.Name = name;
            product.Price = price;
            product.CategoryId = categoryId;
            _repository.Add(product);
        }

        public void Delete(int id)
        {
           _repository.Delete(id);
        }

        public Product Get(int id)
        {
            return _repository.Get(id);
        }

        public List<Product> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(int id, string name, int? price, int? categoryId)
        {
            var product = new Product();
            product.Name = name;
            product.Price = price;
            product.CategoryId = categoryId;
            _repository.Update(id, product);
        }
    }
}
