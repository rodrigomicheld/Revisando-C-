using System;


namespace RentCar.Services {
    class BrasilTaxService {

        public double Tax (double amount) {
            if(amount <= 100.00) {
                return amount * 0.2;
            }
            return amount *0.15;
        }
    }
}
