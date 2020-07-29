using ClasseMetodosAbstratos.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ClasseMetodosAbstratos {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter the number of taxpayer: ");
            int taxpayer = int.Parse(Console.ReadLine());
            
            List<People> people = new List<People>();

            for (int i = 1; i <= taxpayer; i++)
            {
                Console.WriteLine("Taxpayer " + i);
                Console.Write("Which kind of taxpayer (i - individual / c- company): ");
                char typeTaxpayer = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("AnnualIncome R$ ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (typeTaxpayer == 'i')
                {
                    Console.Write("Expense Health: ");
                    double expenseHealth = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    People person = new Individual(name, annualIncome, expenseHealth);
                    people.Add(person);
                }
                else
                {
                    Console.Write("Quantity Employeers: ");
                    int employeer = int.Parse(Console.ReadLine());
                    People person = new Company (name, annualIncome, employeer);
                    people.Add(person);
                }
            }
            Console.WriteLine();
            Console.WriteLine("INCOME TAX");
            double sum = 0.0;
            foreach(People list in people)
            {
                Console.WriteLine(list.Name + " R$ "+list.incomeTax().ToString("f2",CultureInfo.InvariantCulture));
                sum += list.incomeTax();
            }
            Console.WriteLine();
            Console.WriteLine("Sum of income tax R$ "+sum.ToString("f2",CultureInfo.InvariantCulture));
        }
    }
}
