using System;
using System.Globalization;

namespace Aula60 {
    class Program {
        static void Main(string[] args) {

            ContaBancaria conta1;

            Console.WriteLine("Informe o número da conta");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome do titular da conta");
            String titular = Console.ReadLine();
            Console.WriteLine("Deseja realizar um depósito (S- SIm / N- Não)");
            char opcao = char.Parse(Console.ReadLine());
            
            while ((opcao != 'S') && (opcao != 'N'))
            {
                Console.WriteLine("Opção inválida escolha S-sim N-não");
                Console.WriteLine("Deseja realizar um depósito (S- SIm / N- Não)");
                opcao = char.Parse(Console.ReadLine());
            }
            double valor;
            if (opcao == 'S')
            {
                Console.WriteLine("Informe o valor a ser depositado");
                valor = double.Parse(Console.ReadLine());

                while (valor < 1)
                {
                    Console.WriteLine("Valor depositado não pode ser menor que R$1,00");
                    Console.WriteLine("Informe um novo valor");
                    valor = double.Parse(Console.ReadLine());
                }

                conta1 = new ContaBancaria(numeroConta, titular, valor);
            }
            else
            {
                conta1 = new ContaBancaria(numeroConta, titular);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta1);

            Console.WriteLine();
            Console.WriteLine("Informe um valor a ser depositado");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta1.depositar(valor);
            
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta1);

            Console.WriteLine();
            Console.WriteLine("Informe um valor pra sacar");
            valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            conta1.sacar(valor);
            
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta1);
        }
    }
}
