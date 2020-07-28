
namespace HerancaPolimorfismo.Entities {
    class ImportedProduct : Product {

        public double CustomsFee { get; set; }

        public ImportedProduct(string name, double price, double customsFee) : base (name, price) {
            CustomsFee = customsFee;
        }

        public double totalPrice() {
            return Price + CustomsFee;
        }
        public override string priceTag() {
            Price = totalPrice();
            return base.priceTag()+" "+"(Customs Fee: $ "+CustomsFee+")";
        }

    }
    
}
