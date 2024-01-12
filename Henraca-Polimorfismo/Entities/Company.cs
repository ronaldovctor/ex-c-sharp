using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henraca_Polimorfismo.Entities
{
    public class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company() { }
        public Company(string name, double anualIncome, int employees) : base(name, anualIncome)
        {
            NumberOfEmployees = employees;
        }
        public override double Tax()
        {
            double result;
            result = NumberOfEmployees > 10 ? AnualIncome * 0.14 : AnualIncome * 0.16;
            return result;
        }
    }
}
