using System.Globalization;

namespace ProgramBankAccout
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount;

            Console.Write("Enter the client name: ");
            string accountHolder = Console.ReadLine();
            Console.Write("Enter the account number: ");
            int accountNumber = int.Parse(Console.ReadLine());
            Console.Write("Will there be an initial deposit? (y/n)");
            char answerDeposit = char.ToLower(char.Parse(Console.ReadLine()));

            if (answerDeposit == 'y')
            {
                Console.Write("Enter the initial deposit value: ");
                double initialDeposit = double.Parse(Console.ReadLine());
                bankAccount = new BankAccount(accountHolder, accountNumber, initialDeposit);
            } else
            {
                bankAccount = new BankAccount(accountHolder, accountNumber);
            }
            Console.WriteLine();
            Console.WriteLine("Account information: ");
            Console.WriteLine(bankAccount);
        }
    }
}
