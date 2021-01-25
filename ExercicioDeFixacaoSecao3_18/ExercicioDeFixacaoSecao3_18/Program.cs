using System;
using System.Globalization;

namespace ExercicioDeFixacaoSecao3_18 {
    class Program {
        static void Main(string[] args) {
            String produto1 = "Computador", produto2 = "Mesa de escritorio";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0, preco2 = 650.50, medida = 53.234567;

            Console.WriteLine("Produtos");
            Console.WriteLine("{0}, cujo preço é R$ {1}", produto1, preco1); //placeholder
            Console.WriteLine($"{produto2}, cujo preço é R$ {preco2}"); //interpolação
            Console.WriteLine("Registro: " + idade + " anos de idade, código " + codigo + " e gênero: " + genero);//concatenação

            Console.WriteLine("Medida com oito casas decimais:{0:F8}", medida);
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3} ");
            Console.WriteLine("Separador decimal Invariant Culture: " + medida.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
