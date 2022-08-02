using System.Globalization;
using Construtores.Models;

namespace Construtores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int count = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string name = Console.ReadLine();
            Console.Write("Haverá depósito inicial(s/n)? ");
            string confirm = Console.ReadLine().ToString().ToLower();

            BankAccount b = new BankAccount(count, name);

            if (confirm == "s")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double val = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                b.Deposit(val);
            }

            Console.WriteLine($"Dados da conta: {b}");

            Console.Write("Entre um valor para depósito: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b.Deposit(value);

            Console.WriteLine($"Dados da conta atualizados: {b}");

            Console.Write("Entre um valor para saque: ");
            value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b.Withdrawal(value);

            Console.WriteLine($"Dados da conta atualizados: {b}");
        }
    }
}