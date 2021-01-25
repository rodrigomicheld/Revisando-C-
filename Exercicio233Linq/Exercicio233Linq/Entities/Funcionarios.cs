using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio233Linq.Entities {
    class Funcionarios {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public Funcionarios(string name,string email,double salary) {
            Name = name;
            Email = email;
            Salary = salary;
        }
    }
}
