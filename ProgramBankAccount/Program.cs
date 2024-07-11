namespace ProgramBankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount;

            void WriteAccountDetails(string message)
            {
                Console.Write(
                    $"\n** {message}: **" +
                    $"\n{bankAccount}"
                );
            }

            void CheckAnswer(ref char answer, string prompt)
            {
                while (true)
                {
                    try
                    {
                        if (answer == 'y' || answer == 'n')
                            break;

                        throw new ArgumentException("Invalid input. Please type 'y' or 'n'.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"\nWarning! {ex.Message}\n");
                        Console.Write(prompt);
                        string userInput = Console.ReadLine();
                        answer = userInput.Length == 1 ? char.ToLower(userInput[0]) : '0';
                    }
                }
            }

            double ReadPositiveDouble(string prompt)
            {
                double value;
                while (true)
                {
                    try
                    {
                        Console.Write(prompt);
                        value = double.Parse(Console.ReadLine());
                        if (value <= 0)
                        {
                            throw new ArgumentException("The value cannot be 0 or negative.");
                        }
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message} Please enter a positive value.");
                    }
                }
                return value;
            }

            Console.Write("Enter the client name: ");
            string accountHolder = Console.ReadLine();
            Console.Write("Enter the account number: ");
            int accountNumber = int.Parse(Console.ReadLine());

            Console.Write("Will there be an initial deposit? (y/n): ");
            string initialDepositInput = Console.ReadLine();
            char answerInitialDeposit = initialDepositInput.Length == 1 ? char.ToLower(initialDepositInput[0]) : '0';

            CheckAnswer(ref answerInitialDeposit, "Will there be an initial deposit? (y/n): ");

            if (answerInitialDeposit == 'y')
            {
                double initialDeposit = ReadPositiveDouble("Enter the initial deposit amount: ");
                bankAccount = new BankAccount(accountHolder, accountNumber, initialDeposit);
                WriteAccountDetails("Account details");
            }
            else
            {
                bankAccount = new BankAccount(accountHolder, accountNumber);
                WriteAccountDetails("Account details");
            }

            Console.Write("\n\nWould you like to make a deposit? (y/n): ");
            string depositInput = Console.ReadLine();
            char answerDeposit = depositInput.Length == 1 ? char.ToLower(depositInput[0]) : '0';

            CheckAnswer(ref answerDeposit, "\n\nWould you like to make a deposit? (y/n): ");

            if (answerDeposit == 'y')
            {
                double deposit = ReadPositiveDouble("Enter the deposit amount: ");
                bankAccount.Deposit(deposit);
                WriteAccountDetails("Updated account details");
            }

            Console.Write("\n\nWould you like to make a withdrawal? (y/n): ");
            string withdrawInput = Console.ReadLine();
            char answerWithdrawal = withdrawInput.Length == 1 ? char.ToLower(withdrawInput[0]) : '0';

            CheckAnswer(ref answerWithdrawal, "\n\nWould you like to make a withdrawal? (y/n): ");

            if (answerWithdrawal == 'y')
            {
                double withdrawal = ReadPositiveDouble("Enter the withdrawal amount: ");
                bankAccount.Withdrawal(withdrawal);
                WriteAccountDetails("Updated account details");
            }
        }
    }
}
