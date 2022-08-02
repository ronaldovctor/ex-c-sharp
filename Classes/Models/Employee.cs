using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public double BruteWage { get; set; }
        public double Taxe { get; set; }

        public double LiquidWage()
        {
            double result = BruteWage - Taxe;
            return result;
        }

        public void IncreaseWage(double percentage)
        {
            BruteWage += (BruteWage * (percentage / 100));
        }

        public override string ToString()
        {
            return $"{Name}, $ {LiquidWage()}";
        }
    }
}
