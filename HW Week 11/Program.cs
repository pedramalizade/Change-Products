using HW_Week_11.Repository;
using HW_Week_11.Service;

IProductService productService = new ProductService();


start();
void start()
{
    while (true)
    {
        Console.WriteLine("1. Add Productd");
        Console.WriteLine("2. Show All Products");
        Console.WriteLine("3. Show Product");
        Console.WriteLine("4. Update Product");
        Console.WriteLine("5. Delet Product");
        Console.Write("Chioce Option: ");

        int output = int.Parse(Console.ReadLine());
        CheckOutPut(output);
    }

    void CheckOutPut(int output)
    {
        switch (output)
        {
            case 1:
                Console.Write("Enter Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter Price: ");
                int price = int.Parse(Console.ReadLine());
                Console.Write("Enter categoryId: ");
                int categoryId = int.Parse(Console.ReadLine());
                productService.Add(name, price, categoryId);
                break;
            case 2:
                foreach(var item in productService.GetAll())
                {
                    Console.WriteLine(item); 
                }
                break;
            case 3:
                Console.Write("Enter Id: ");
                int id = int.Parse(Console.ReadLine());
                var product = productService.Get(id);
                Console.WriteLine(product);
                break;
            case 4:
                foreach (var item in productService.GetAll())
                {
                    Console.WriteLine(item);
                }
                Console.Write("Enter Product Number: ");

                var productId = int.Parse(Console.ReadLine());

                Console.Write("Enter Name: ");
                string nameUpdate = Console.ReadLine();
                Console.Write("Enter Price: ");
                int priceUpdate = int.Parse(Console.ReadLine());
                Console.Write("Enter categoryId: ");
                int categoryIdUpdate = int.Parse(Console.ReadLine());
                productService.Update(productId, nameUpdate, priceUpdate, categoryIdUpdate);
                break;
            case 5:
                foreach (var item in productService.GetAll())
                {
                    Console.WriteLine(item);
                }
                Console.Write("Enter Product Number: ");
                var productid = int.Parse(Console.ReadLine());

                productService.Delete(productid);
                break;
            default:
                Console.WriteLine("wrong Number");
                break;
        }
        
    }
}