using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class Student
    {
        public string Name { get; set; }
        public double Grade1 { get; set; }
        public double Grade2 { get; set; }
        public double Grade3 { get; set; }

        private int average = 60;

        public double FinalGrade()
        {
            double result = Grade1 + Grade2 + Grade3;
            return result;
        }

        public string HasPassed()
        {
            string result = FinalGrade() > average ? $"Aprovado!" : $"Reprovado! Faltaram {(average - FinalGrade()).ToString("F2", CultureInfo.InvariantCulture)} pontos.";
            return result;
        }
    }
}
