using System;
using System.Collections.Generic;
using System.Text;
using UseInterface.Entities;

namespace UseInterface.Services {
    class ContractService {

        private ITypePayment _onlinePaymentService;

        public ContractService(ITypePayment onlinePaymentService) {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract,int months) {
            double basicQuota = contract.Value / months;
            for(int i = 1; i <= months; i++) {
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = basicQuota + _onlinePaymentService.Interest(basicQuota,i);
                double fullQuota = updatedQuota + _onlinePaymentService.PaymentFee(updatedQuota);
                contract.AddPayment(new Payment(date,fullQuota));
            }
        }
    }
}
