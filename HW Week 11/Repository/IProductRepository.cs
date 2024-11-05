using HW_Week_11.Config;
using HW_Week_11.Entitis;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Week_11.Repository
{
    public interface IProductRepository
    {
        public void Add(Product product);


        public Product Get(int id);

        public List<Product> GetAll();

        public void Update(int id, Product product);

        public void Delete(int id);
       

    }
}
