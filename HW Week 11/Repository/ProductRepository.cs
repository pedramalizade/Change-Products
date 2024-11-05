using Dapper;
using HW_Week_11.Config;
using HW_Week_11.Entitis;
//using HW_Week_11.Queries;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Week_11.Repository
{
    public class ProductRepository : IProductRepository
    {

        public void Add(Product product)
        {
            using (var conetion = new SqlConnection(DatabaseConfige.ConnectionString))
            {
                conetion.Execute("insert into Products (Name, Price, CategoryId) values (@Name, @Price, @CategoryId)", new {Name = product.Name, Price = product.Price, CategoryId = product.CategoryId});
            }
        }

        public Product Get(int id)
        {
            using (var conetion = new SqlConnection(DatabaseConfige.ConnectionString))
            {
                return conetion.QueryFirstOrDefault<Product>("select p.Id, p.Name, p.Price, c.Name as CategoryName from Products p join Categories c on c.Id = p.CategoryId where p.Id = @id", new { Id = id });
            }
        }
        public List<Product> GetAll()
        {
            using (var conetion = new SqlConnection(DatabaseConfige.ConnectionString))
            {
                return conetion.Query<Product>("select p.Id, p.Name, p.Price, c.Name as CategoryName from products p join Categories c on p.CategoryId = c.Id;").ToList();
            }
        }
        public void Update(int id, Product product)
        {
            using (var conetion = new SqlConnection(DatabaseConfige.ConnectionString))
            {
                conetion.Execute("update Products set Name = @Name, Price = @Price, CategoryId = @CategoryId where Id = @Id", new { Name = product.Name, Price = product.Price, CategoryId = product.CategoryId, Id = id });
            }
        }
        public void Delete(int id)
        {
            using (var conetion = new SqlConnection(DatabaseConfige.ConnectionString))
            {
                conetion.Execute("delete Products where Id = @Id", new {Id = id});
            }
        }
    }
}
