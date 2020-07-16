using Composicao.Entities.Enums;
using System.Collections.Generic;
using System.Xml.Schema;

namespace Composicao.Entities {
    class Worker {

        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament) {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void addContract(HourContract contract) {
            Contracts.Add(contract);
        }
        public void removeContract(HourContract contract) {
            Contracts.Remove(contract);
        }
        public double income(int year, int month) {
            double total = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    total += contract.totalValue();
                }
            }
            return total;
        }

    }
}
