using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson5task.Database;
using Lesson5task.Model;
using Lesson5task.Services;

namespace Lesson5task
{
    internal class Program
    {
        static void Main(string[] args)

        {
            StoreAppDataBase database = new StoreAppDataBase();

            ProductService productService = new ProductService(database);
            Product product1 = new Product
            {
                Id = Guid.NewGuid(),
                Name = "Computer",
                Price = 12000,
                Description = "A high performance computer"
            };

            Product product2 = new Product
            {
                Id = Guid.NewGuid(),
                Name = "Computer2",
                Price = 12000,
                Description = "A high performance computer"
            };

            Product product3 = new Product
            {
                Id = Guid.NewGuid(),
                Name = "Computer3",
                Price = 12000,
                Description = "A high performance computer"
            };

            Product product4 = new Product
            {
                Id = Guid.NewGuid(),
                Name = "Computer4",
                Price = 12000,
                Description = "A high performance computer"
            };

            Order order1 = new Order
            {
                Id = Guid.NewGuid(),
                Products = new List<Product> { product1, product2 },
                TotalPrice = 0
            };

            Order order2 = new Order
            {
                Id = Guid.NewGuid(),
                Products = new List<Product> { product3, product4 },
                TotalPrice = 0

            };
            Customer customer = new Customer
            {
                Id = Guid.NewGuid(),
                Name = "Gulcin",
                Surname = "Hebibilayeva",


            };
    
            database.Products.Add(product1);
            database.Products.Add(product2);
            database.Products.Add(product3);
            database.Products.Add(product4);
            database.Customers.Add(customer);
            database.Orders.Add(order1);
            database.Orders.Add(order2);

           
            while (true)
            {
                Console.WriteLine("Welcome StoreApp");

                Console.WriteLine("1.Show all products");
                Console.WriteLine("2.Add Products");
                Console.WriteLine("3.Update Products");
                Console.WriteLine("4.Delete Produts");
                Console.WriteLine("5.Show all Customers");
                Console.WriteLine("6.Show all Orders");
                Console.WriteLine("7.Add Order");
                Console.WriteLine("8.Update Order");
                Console.WriteLine("9.Delete Order");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("1.Show all products");
                        foreach (var products in database.Products)
                        {
                            Console.WriteLine($"Product ID{products.Id}Product Name:{products.Name}\nproducts.Description{products.Description}\n{products.Price}");
                        }
                        break;

                    case "2":
                        Console.WriteLine("2.Add Products");
                        Product product = new Product();
                        product.Id = Guid.NewGuid();
                        Console.WriteLine("Enter Product name");
                        product.Name = Console.ReadLine();
                        Console.WriteLine("Enter Product description");
                        product.Description = Console.ReadLine();

                        Console.WriteLine("Enter Product description");
                        double price = Double.Parse(Console.ReadLine());

                        if (price > 0)
                            product.Price = price;
                        else { Console.WriteLine("Dogru qiymet daxil edin"); }
                        
                        database.Products.Add(product);
                        break;

                        case "3":
                        Console.WriteLine("3.Update Products");
                        break;


                    case "4":
                        Console.WriteLine("4. Məhsulu ID ilə sil");
                        string idInput = Console.ReadLine();

                        if (Guid.TryParse(idInput, out Guid id))
                        {
                            var productToDelete = productService.GetById(id); 
                            if (productToDelete != null)
                            {
                                productService.DeleteById(id);
                                Console.WriteLine("Məhsul silindi.");
                            }
                            else
                            {
                                Console.WriteLine("Məhsul tapılmadı.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Düzgün ID formatı daxil edilməyib.");
                        }
                        break;

                    case "5":
                        Console.WriteLine("5.Show all Customers");
                        foreach (var showcustomer in database.Customers)
                        {
                            Console.WriteLine(showcustomer);
                        }
                        break;
                        case "6":
                        Console.WriteLine("Show all Orders");

                        foreach(var showOrder in database.Orders)
                        {
                            Console.WriteLine(showOrder);
                        }
                        break;

                    case "7":
                        Console.WriteLine("7.Add Order");
                        Order order=new Order();
                        Console.WriteLine("");

                        break;
                  
                }
            }


            Console.WriteLine("Welcome StoreApp");
            
            Console.WriteLine("1.Show all products");
            Console.WriteLine("2.Add Products");
            Console.WriteLine("3.Update Products");
            Console.WriteLine("4.Delete Produts");
            Console.WriteLine("5.Show all Customers");
            Console.WriteLine("6.Show all Orders");
            Console.WriteLine("7.Add Order");
            Console.WriteLine("8.Update Order");
            Console.WriteLine("9.Delete Order");
        }



        
    }
}
