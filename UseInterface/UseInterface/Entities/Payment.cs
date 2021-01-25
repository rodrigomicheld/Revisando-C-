using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace UseInterface.Entities {
    class Payment {
        public DateTime DtPayment { get; set; }
        public double ValueInstallments { get; set; }

        public Payment(DateTime dtPayment,double valueInstallments) {
            DtPayment = dtPayment;
            ValueInstallments = valueInstallments;
        }

        public override string ToString() {
            return DtPayment.ToString("dd/MM/yyyy")
                + " - "
                + ValueInstallments.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
