using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henraca_Polimorfismo.Entities
{
    public class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual() { }
        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }
        public override double Tax()
        {
            double result;
            result = AnualIncome < 20000 ? AnualIncome * 0.15 : AnualIncome * 0.25;
            result -= HealthExpenditures * 0.50;
            return result;
        }
    }
}
