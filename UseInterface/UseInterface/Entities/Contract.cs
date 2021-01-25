
using System;
using System.Collections.Generic;

namespace UseInterface.Entities {
    class Contract {
        public int Number{ get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }
        public List<Payment> Payment { get; set; }
        
        public Contract(int number,DateTime date,double value) {
            Number = number;
            Date = date;
            Value = value;
            Payment = new List<Payment>();
        }

        public void AddPayment(Payment payment) {
            Payment.Add(payment);
        }
    }
}
