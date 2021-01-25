using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using UtilizandoLinq.Entities;
using System.Linq;

namespace UtilizandoLinq {
    class Program {
        static void Main(string[] args) {
            Console.Write("entre com o caminho do arquivo: ");
            string path = Console.ReadLine();

            List<Product> list = new List<Product>();

            using(StreamReader sr = File.OpenText(path)) {
                while(!sr.EndOfStream) {
                    string[] campos = sr.ReadLine().Split(',');
                    string name = campos[0];
                    double price = double.Parse(campos[1],CultureInfo.InvariantCulture);
                    list.Add(new Product(name,price));
                }
            }
            //tira a media de todos os produtos contidos na lista
            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Média dos preços dos Produtos na lista: "+avg.ToString("F2",CultureInfo.InvariantCulture));

            var names = list.Where(p => p.Price < avg).OrderByDescending(p =>p.Name).Select(p=>p.Name);
            foreach(string name in names) {
                Console.WriteLine(name);
            }
        }
    }
}
