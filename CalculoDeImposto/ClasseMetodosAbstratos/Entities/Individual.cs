
namespace ClasseMetodosAbstratos.Entities {
    class Individual : People {
        public double ExpenseHealth { get; set; }

        public Individual(string name, double annualIncome, double expenseHealth) : base(name, annualIncome) {
            ExpenseHealth = expenseHealth;
        }

        public override double incomeTax() {
            double tax = 20000.00;

            if (AnnualIncome <= tax)
            {
                return ((AnnualIncome * 0.15) - (ExpenseHealth * 0.5));
            }
            else
            {
                return ((AnnualIncome * 0.25) - (ExpenseHealth * 0.5));
            }
        }
    }
}
