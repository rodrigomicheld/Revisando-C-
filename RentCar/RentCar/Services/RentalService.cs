using RentCar.Entities;
using System;

namespace RentCar.Services {
    class RentalService {
        public double PriceHour { get; private set; }
        public double PriceDay { get; private set; }

        private BrasilTaxService brasilTaxService = new BrasilTaxService();

        public RentalService(double priceHour,double priceDay) {
            PriceHour = priceHour;
            PriceDay = priceDay;
        }

        public void ProcessInvoice(CarRental carRental) {
            TimeSpan duration = carRental.DateFinish.Subtract(carRental.DateStart);
            double basicPayment;

            if (duration.TotalHours <= 12.0) {
                basicPayment = PriceHour * Math.Ceiling(duration.TotalHours);
            }
            else {
                basicPayment = PriceDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = brasilTaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment,tax);

        }
    }
}
