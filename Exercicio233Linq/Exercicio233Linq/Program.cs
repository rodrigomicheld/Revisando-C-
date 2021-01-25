using Exercicio233Linq.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Exercicio233Linq {
    class Program {
        static void Main(string[] args) {
            
            Console.Write("entre com o caminho do arquivo: ");
            string path = Console.ReadLine();

            List<Funcionarios> func = new List<Funcionarios>();

            using(StreamReader sr = File.OpenText(path)) {
                while(!sr.EndOfStream) {
                    string[] campos = sr.ReadLine().Split(',');
                    string name = campos[0];
                    string email = campos[1];
                    double salario = double.Parse(campos[2],CultureInfo.InvariantCulture);
                    func.Add(new Funcionarios(name,email,salario));
                }
            }
            Console.Write("Informe um salário para filtrar os funcionarios: ");
            double valor = double.Parse(Console.ReadLine());

            var names = func.Where(p => p.Salary > valor).OrderBy(p => p.Email).Select(p => p.Email);
            foreach(string dados in names) {
                Console.WriteLine(dados);
            }

            Console.Write("Soma dos salários onde O nome do Funcionário começa com a letra 'M' :"+func.Where(p=>p.Name[0]=='M').Sum(p => p.Salary));
            
        }
    }
}

