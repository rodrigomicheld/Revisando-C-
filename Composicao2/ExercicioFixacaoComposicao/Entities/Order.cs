

using ExercicioFixacaoComposicao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioFixacaoComposicao.Entities {
    class Order {

        DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order(OrderStatus status, Client client) {
            Date = DateTime.Now;
            Status = status;
            Client = client;
        }

        public void addItem(OrderItem item) {
            Items.Add(item);

        }
        public void removeItem(OrderItem item) {
            Items.Remove(item);

        }

        public double total() {
            double total=0.0;
            foreach (OrderItem list in Items)
            {
                total += list.subTotal();
            }
            return total;
        }
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMARY:");
            sb.Append("Order Moment: ");
            sb.AppendLine(Date.ToString());
            sb.Append("Order Status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append(" (");
            sb.Append(Client.BirthDate.ToShortDateString());
            sb.Append(") - ");
            sb.AppendLine(Client.Email);
            sb.AppendLine("Order Items: ");

            foreach(OrderItem item in Items)
            {
                sb.Append(item.Product.Name);
                sb.Append(", $");
                sb.Append(item.Price);
                sb.Append(", Quantity: ");
                sb.Append(item.Quantity);
                sb.Append(", SubTotal: $");
                sb.AppendLine(item.subTotal().ToString("f2",CultureInfo.InvariantCulture));
                
            }
            sb.Append("Total Price $");
            sb.Append(total().ToString("f2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
