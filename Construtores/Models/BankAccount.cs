using System.Globalization;

namespace Construtores.Models
{
    public class BankAccount
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; private set; }
        private double WithdrawalFee = 5.00;

        public BankAccount() { }
        public BankAccount(int number)
        {
            Number = number;
        }
        public BankAccount(int number, string holder) : this(number)
        {
            Holder = holder;
        }
        public void Deposit(double value)
        {
            Balance += value;
        }
        public void Withdrawal(double value)
        {
            Balance -= WithdrawalFee + value;
        }
        public override string ToString()
        {
            return $"Conta: {Number}, Titular: {Holder}, Saldo: ${Balance.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
