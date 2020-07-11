using System;
using System.Globalization;

namespace Composicao {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter Departament's name: ");
            string nameDepartament = Console.ReadLine();
            Departament departament = new Departament { name = nameDepartament };
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            String name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior: ");
            String level = Console.ReadLine();
            Console.Write("Base Salary: ");
            double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Worker worker = new Worker { name = name, baseSalary = salary};
        }
    }
}
