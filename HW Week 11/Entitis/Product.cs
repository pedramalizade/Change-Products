using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace HW_Week_11.Entitis
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Price { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public override string ToString()
        {
            return $"id = {Id} , Name = {Name} , Price = {Price} , CategoryName = {CategoryName}";
        }
        public Product(int id, string? name, int? price, int? categoryId)
        {
            Id = id ;
            Name = name ;
            Price = price ;
            CategoryId = categoryId ;
        }
        public Product()
        {

        }
    }
}
