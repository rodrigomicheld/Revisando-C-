
using ExercicioDeExcessoes.Exceptions;

namespace ExercicioDeExcessoes.Entities {
    class Account {

        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit) {
            if ((balance < 0) || (withdrawLimit< 0))
            {
                throw new AccountException("Balance e/ou Withdraw limit with value invalid");
            }
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        private void deposit(double ammount) {
            if (ammount <= 0)
            {
                throw new AccountException("Invalid deposit ammount");
            }
            Balance += ammount;
        }

        public void withdraw (double ammount) {
            if (ammount > Balance)
            {
                throw new AccountException("Isufficient account balance");
            }
            if (ammount > WithdrawLimit)
            {
                throw new AccountException("withdrawal limit exceeded");
            }
            Balance -= ammount;
        }
    }
}
