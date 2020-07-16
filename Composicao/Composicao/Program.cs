using Composicao.Entities;
using Composicao.Entities.Enums;
using System;
using System.Globalization;


namespace Composicao {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter Departament's name: ");
            string nameDepartament = Console.ReadLine();
            while (nameDepartament == "")
            {
                Console.Write("Departament can't empty, enter Departament's name: ");
                nameDepartament = Console.ReadLine();
            }

            Departament departament = new Departament { Name = nameDepartament };

            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            String name = Console.ReadLine();
            while (name == "")
            {
                Console.Write("Worker name cannot be empty, enter a new name: ");
                name = Console.ReadLine();
            }

            Console.Write("Level (Junior/MidLevel/Senior): ");
            String nameLevel = Console.ReadLine().ToLower();
            WorkerLevel level = new WorkerLevel();

            while ((nameLevel != "junior") && (nameLevel != "midlevel") && (nameLevel != "senior"))
            {
                Console.Write("Invalid level, enter a new level (Junior/MidLevel/Senior): ");
                nameLevel = Console.ReadLine().ToLower();
            }

            switch (nameLevel)
            {
                case "junior":
                    level = Enum.Parse<WorkerLevel>("junior");
                    break;
                case "midlevel":
                    level = Enum.Parse<WorkerLevel>("midLevel");
                    break;
                case "senior":
                    level = Enum.Parse<WorkerLevel>("senior");
                    break;
            }

            Console.Write("Base Salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (salary <= 0)
            {
                Console.Write("Invalid salary, enter a new Salary: ");
                salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Worker worker = new Worker(name, level, salary, departament);

            Console.Write("How many contracts to this worker? ");
            int contracts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= contracts; i++)
            {
                Console.WriteLine("Enter #" + i + " contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valueHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int durationHour = int.Parse(Console.ReadLine());
                HourContract hourContract = new HourContract(date, valueHour, durationHour);
                worker.addContract(hourContract);
            }

            Console.Write("Enter moth abd year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();

            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3,4));
            
            double total = worker.income(year, month);

            Console.WriteLine();
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Departament: " + worker.Departament.Name);
            Console.WriteLine("Income for " + monthAndYear + " R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
