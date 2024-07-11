
using System.Globalization;

namespace ProgramBankAccout
{
    class BankAccount
    {

        public string AccountHolder { get; set;}
        public int AccountNumber { get; private set; }
        public double Balance { get; private set; }

        public BankAccount(string accountHolder, int accountNumber)
        {
            AccountHolder = accountHolder;
            AccountNumber = accountNumber;
        }

        public BankAccount(string accountHolder, int accountNumber, double balance) : this(accountHolder, accountNumber)
        {
            Balance = balance;
        }
                
        public override string ToString()
        {
            return $"Account Holder: {AccountHolder}\nAccount Number: {AccountNumber}\nBalance: {Balance.ToString("C")}";
        }

        public void RegisterName(string name)
        {
            AccountHolder = name;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        internal void Withdrawal(double withdrawal)
        {
            Balance -= withdrawal;
            Balance -= 5;
        }
    }
}
