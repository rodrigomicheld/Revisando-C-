
using System.Globalization;
using System.Runtime;
using System.Text;

namespace HerancaPolimorfismo.Entities {
    class Product {

        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price) {
            Name = name;
            Price = price;
        }

        public virtual string priceTag() {

            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" $");
            sb.Append(Price.ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }

        public override string ToString() {
            return priceTag();
        }
    }
}
