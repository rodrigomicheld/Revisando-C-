
namespace ClasseMetodosAbstratos.Entities {
    class Company : People {

        public int QuantityEmployeers { get; set; }

        public Company(string name, double annualIncome, int quantityEmployeers) : base(name, annualIncome) {
            QuantityEmployeers = quantityEmployeers;
        }

        public override double incomeTax() {
            if (QuantityEmployeers <= 10)
            {
                return (AnnualIncome * 0.16);
            }
            else
            {
                return (AnnualIncome * 0.14);
            }
        }
    }
}
