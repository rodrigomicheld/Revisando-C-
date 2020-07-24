using HerancaPolimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace HerancaPolimorfismo {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter the number of employees: ");
            int quant = int.Parse(Console.ReadLine());
            Console.WriteLine();
            List<Employee> listEmployees = new List<Employee>();

            for (int i = 1; i <= quant; i++)
            {
                Console.WriteLine("Employee #" + i + " data:");
                Console.Write("Outsourced (Y/N): ");
                char typeEmployee = char.Parse(Console.ReadLine().ToLower());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hour = int.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (typeEmployee == 'y')
                {
                    Console.Write("Additional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listEmployees.Add(new OutsourcedEmployee(name, hour, valuePerHour, additionalCharge));
                }
                else
                {
                    listEmployees.Add(new Employee(name, hour, valuePerHour));
                }

            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (Employee list in listEmployees)
            {
                Console.WriteLine(list.Name +" - $ "+list.payment().ToString("f2",CultureInfo.InvariantCulture)); 
            }
        }
    }
}
