using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithFiles.Entities {
    class Product {

        public string nameProduct { get; set; }
        public double valueProduct { get; set; }
        public int quantity { get; private set; }

        public Product (string name, double valueProduct, int quantity) {
            nameProduct = name;
            this.valueProduct = valueProduct;
            IncreaseQuantity(quantity);
        }

        private void IncreaseQuantity(int quant) {
            quantity += quant;
        }

        public double TotalSale() {
            return valueProduct * quantity;
        }
    }
}
