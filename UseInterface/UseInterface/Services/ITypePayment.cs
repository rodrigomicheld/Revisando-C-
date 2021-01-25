using System;
using System.Collections.Generic;
using System.Text;

namespace UseInterface.Services {
    interface ITypePayment {
        double PaymentFee(double amount);
        double Interest(double amount,int months);
    }
}
