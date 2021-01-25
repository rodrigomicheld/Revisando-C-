using System;
using System.Collections.Generic;
using System.IO;

namespace Dictionary214 {
    class Program {
        static void Main(string[] args) {
            Dictionary<string,int> dictionary = new Dictionary<string,int>();

            Console.Write("Entre com o caminho do arquivo: ");
            string path = Console.ReadLine();

            try {
                using(StreamReader sr = File.OpenText(path)) {
                    while(!sr.EndOfStream) {
                        string[] registro = sr.ReadLine().Split(';');
                        string candidato = registro[0];
                        int voto = int.Parse(registro[1]);

                        if(!dictionary.ContainsKey(candidato)) {
                            dictionary.Add(candidato,voto);

                        }
                        else {
                            dictionary[candidato] += voto;
                        }
                    }
                    foreach(var list in dictionary) {
                        Console.WriteLine(list.Key + " " + list.Value);
                    }
                }

            }
            catch(Exception e) {
                Console.WriteLine(e);
            }


        }
    }
}
