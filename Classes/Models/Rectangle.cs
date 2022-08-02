using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class Rectangle
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public double Area()
        {
            double result = Altura * Largura;
            return result;
        }

        public double Diagonal()
        {
            double result = Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
            return result;
        }

        public double Perimeter()
        {
            double result = (Altura * 2) + (Largura * 2);
            return result;
        }
    }
}
