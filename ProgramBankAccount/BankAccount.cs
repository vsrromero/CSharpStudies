
namespace ProgramBankAccount
{
    public class BankAccount
    {

        public string AccountHolder { get; set;}
        public int AccountNumber { get; private set; }
        public double Balance { get; private set; }

        public BankAccount(string accountHolder, int accountNumber)
        {
            AccountHolder = accountHolder;
            AccountNumber = accountNumber;
        }

        public BankAccount(string accountHolder, int accountNumber, double initialDeposit) : this(accountHolder, accountNumber)
        {
            Deposit(initialDeposit);
        }
                
        public override string ToString()
        {
            return $"Account Holder: {AccountHolder}\nAccount Number: {AccountNumber}\nBalance: {Balance.ToString("C")}";
        }

        private double CheckPositiveValue(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Internal error! The amount can not be negative");
            }

            return value;
        }

        public void Deposit(double amount)
        {
            double depositAmount = CheckPositiveValue(amount);
            Balance += depositAmount;
            
        }

        internal void Withdrawal(double withdrawal)
        {
            double withdrawalAmount = CheckPositiveValue(withdrawal);
            Balance -= withdrawalAmount + 5;
        }
    }
}
