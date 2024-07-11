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
            Console.Write("Will there be an initial deposit? (y/n): ");
            char answerInitialDeposit = char.ToLower(char.Parse(Console.ReadLine()));

            while (answerInitialDeposit != 'y' && answerInitialDeposit != 'n')
            {
                Console.WriteLine("" +
                    "\nWarning!" +
                    "\nPlease, type a valid answer, 'y' or 'n'! \n");
                Console.Write("Will there be an initial deposit? (y/n): ");
                answerInitialDeposit = char.ToLower(char.Parse(Console.ReadLine()));
            }

            if (answerInitialDeposit == 'y')
            {
                Console.Write("Enter the initial deposit amount: ");
                double initialDeposit = double.Parse(Console.ReadLine());
                bankAccount = new BankAccount(accountHolder, accountNumber, initialDeposit);
            } else
            {
                bankAccount = new BankAccount(accountHolder, accountNumber);
                return;
            }
            Console.WriteLine("\n** Account details: **");
            Console.WriteLine(bankAccount);

            Console.Write("\n\nWould you like to make a deposit? (y/n): ");
            char answerDeposit = char.ToLower(char.Parse(Console.ReadLine()));

            while (answerDeposit != 'y' && answerDeposit != 'n')
            {
                Console.WriteLine("" +
                    "\nWarning!" +
                    "\nPlease, type a valid answer, 'y' or 'n'!\n");
                Console.Write("Would you like to make a deposit? (y/n): ");
                answerDeposit = char.ToLower(char.Parse(Console.ReadLine()));
            }

            if (answerDeposit == 'y')
            {
                Console.WriteLine();
                Console.Write("Enter the deposit amount: ");
                double deposit = double.Parse(Console.ReadLine());
                bankAccount.Deposit(deposit);
                Console.WriteLine("\n** Updated account details: **");
                Console.WriteLine(bankAccount);
            } else
            {
                return;
            }            
            
            Console.Write("\n\nWould you like to make a withdrawal? (y/n): ");
            char answerWithdrawal = char.ToLower(char.Parse(Console.ReadLine()));

            while (answerWithdrawal != 'y' && answerWithdrawal != 'n')
            {
                Console.WriteLine("" +
                    "\nWarning!" +
                    "\nPlease, type a valid answer, 'y' or 'n'!\n");
                Console.Write("Would you like to make a withdrawal? (y/n): ");
                answerWithdrawal = char.ToLower(char.Parse(Console.ReadLine()));
            }

            if (answerWithdrawal == 'y')
            {
                Console.WriteLine();
                Console.Write("Enter the withdrawal amount: ");
                double withdrawal = double.Parse(Console.ReadLine());
                bankAccount.Withdrawal(withdrawal);
                Console.WriteLine("\n** Updated account details: **");
                Console.WriteLine(bankAccount);
            } else
            {
                return;
            }
            


        }
    }
}
