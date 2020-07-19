using ExercicioFixacaoComposicao.Entities;
using ExercicioFixacaoComposicao.Entities.Enums;
using System;

namespace ExercicioFixacaoComposicao {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter Client Data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birth = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birth);
            Console.WriteLine();
            Console.WriteLine("Enter Order Data:");
            Console.Write("Status: ");
            OrderStatus status = new OrderStatus();
            status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(status, client);

            Console.Write("How many items to this order: ");
            int quant = int.Parse(Console.ReadLine());

            for (int i=1; i <= quant; i++)
            {
                Console.WriteLine("Enter #"+i+" item data:");
                Console.Write("Product name: ");
                string product = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product prod = new Product(product, price);
                OrderItem orderItem = new OrderItem(quantity, prod);
                order.addItem(orderItem);
            }
            Console.Write(order);
            



        }
    }
}
