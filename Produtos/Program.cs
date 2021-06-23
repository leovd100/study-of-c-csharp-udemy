using System;
using System.Collections.Generic;
using System.Globalization;
using Produtos.Entities;
namespace Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> product = new List<Product>();

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Product #{(i+1)} data: " );
                Console.Write("Common, used or imported (c/u/i) ?");
                char c = char.Parse(Console.ReadLine().ToLower());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (c == 'i')
                {
                    Console.Write("Customs fee : ");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    product.Add(new ImportedProduct(name, price, fee));
                }
                else if (c == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    product.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    product.Add(new Product(name, price));
                }

               

            }

            Console.WriteLine("PRICE TAGS: ");
            foreach (Product prod in product)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
