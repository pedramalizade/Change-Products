using HW_Week_11.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Week_11.Service
{
    public interface IProductService
    {
        public void Add(string name, int? price, int? categoryId);
        public Product Get(int id);
        public List<Product> GetAll();
        public void Update(int id, string name, int? price, int? categoryId);
        public void Delete(int id);
    }
}
