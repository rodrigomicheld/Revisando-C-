using Exemplo212.Entities;
using System;
using System.Collections.Generic;

namespace Exemplo212 {
    class Program {
        static void Main(string[] args) {
            HashSet<Curso> a = new HashSet<Curso>();
            HashSet<Curso> b = new HashSet<Curso>();
            HashSet<Curso> c = new HashSet<Curso>();
           
            Console.Write("Quantos estudantes estão no curso A? ");
            int alunos = int.Parse(Console.ReadLine());
            for(int i = 0; i < alunos; i++) {
                a.Add(new CursoA (int.Parse(Console.ReadLine())));
            }
            Console.Write("Quantos estudantes estão no curso B? ");
            alunos = int.Parse(Console.ReadLine());
            for(int i = 0; i < alunos; i++) {
                b.Add(new CursoB(int.Parse(Console.ReadLine())));
            }
            Console.Write("Quantos estudantes estão no curso C? ");
            alunos = int.Parse(Console.ReadLine());
            for(int i = 0; i < alunos; i++) {
                c.Add(new CursoC(int.Parse(Console.ReadLine())));
            }
            HashSet<Curso> result = new HashSet<Curso>(a);
            result.UnionWith(b);
            result.UnionWith(c);

            Console.WriteLine("Total de estudantes do instrutor: "+ result.Count);
            

            
        }
    }
}
