using System;
using System.Globalization;
using UseInterface.Entities;
using UseInterface.Services;

namespace UseInterface {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number,date,value);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract,installments);

            Console.WriteLine("Installments:");
            foreach(Payment installment in contract.Payment) {
                Console.WriteLine(installment);
            }

        }
    }
}
