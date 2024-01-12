using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enum_Composicao.Entities.Enum;

namespace Enum_Composicao.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; }
        public Client Buyer { get; set; }

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client buyer)
        {
            Moment = moment;
            Status = status;
            Buyer = buyer;
        }

        public void AddOrder(OrderItem item)
        {
            Items.Add(item);
        }

        public double SubTotal()
        {
            double total = 0;
            foreach(OrderItem item in Items)
            {
                total += item.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder str = new();
            foreach (OrderItem item in Items)
            {
                str.AppendLine($"{item.Product.Name} - Quantity: {item.Quantity} - Subtotal: {item.SubTotal().ToString("F2", CultureInfo.InvariantCulture)}");
            }
            return str.ToString();
        }
    }
}
