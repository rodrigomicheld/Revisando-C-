using HerancaPolimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace HerancaPolimorfismo {
    class Program {
        static void Main(string[] args) {

            Console.Write("Enter the number of products: ");
            int quant = int.Parse(Console.ReadLine());
            Product product;
            List<Product> productList = new List<Product>();

            for (int i = 1; i <= quant; i++)
            {
                Console.WriteLine("Product #" + i + " data:");
                Console.Write("Common , used or imported (c/u/i): ");
                char typeProduct = char.Parse(Console.ReadLine().ToLower());

                switch (typeProduct)
                {
                    case 'c':
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Price $: ");
                        double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        product = new Product(name, price);
                        productList.Add(product);
                        break;
                    case 'u':
                        Console.Write("Name: ");
                        name = Console.ReadLine();
                        Console.Write("Price $: ");
                        price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        DateTime date = new DateTime();
                        Console.Write("Manufacture date (dd/MM/yyyy): ");
                        date = DateTime.Parse(Console.ReadLine());
                        product = new UsedProduct(name, price, date);
                        productList.Add(product);
                        break;
                    case 'i':
                        Console.Write("Name: ");
                        name = Console.ReadLine();
                        Console.Write("Price $: ");
                        price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Customs Fee $: ");
                        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        product = new ImportedProduct(name, price, customsFee);
                        productList.Add(product);
                        break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach(Product prod in productList)
            {
                Console.WriteLine(prod);
            }
        }
    }
}
