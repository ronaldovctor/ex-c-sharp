using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }

        public void AddProducts(int quantity)
        {
            Amount += quantity;
        }

        public void RemoveProducts(int quantity)
        {
            Amount -= quantity;
        }

        public double TotalValue()
        {
            double total = Amount * Price;
            return total;
        }

        public override string ToString()
        {
            return $"{Name}, {Price}, {Amount.ToString("F2", CultureInfo.InvariantCulture)} unidades, Total: ${TotalValue().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
