﻿using ExercicioDeExcessoes.Entities;
using ExercicioDeExcessoes.Exceptions;
using System;
using System.Globalization;

namespace ExercicioDeExcessoes {
    class Program {
        static void Main(string[] args) {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double limit = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Account account = new Account(number, holder, balance, limit);
                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.withdraw(withdraw);
                Console.WriteLine("New balance: "+account.Balance.ToString("f2",CultureInfo.InvariantCulture));
            }
            catch (AccountException e)
            {
                Console.WriteLine("Error: " +e.Message );
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
