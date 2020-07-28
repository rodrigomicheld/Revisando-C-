﻿

using System;
using System.Globalization;
using System.Text;

namespace HerancaPolimorfismo.Entities {
    class UsedProduct : Product {

        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price) {
            ManufactureDate = manufactureDate;
        }

        public override string priceTag() {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" (Used) $");
            sb.Append(Price.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append(" (Manufacture date: ");
            sb.Append(ManufactureDate.ToShortDateString());
            sb.Append(")");

            return sb.ToString();
        }

    }
}
