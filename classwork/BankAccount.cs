using System;

namespace First_Day
{
    public class BankAccount
    {
        public static void Run()
        {
            double balance = 500.00;

            Console.Write("Enter your Account Number: ");
            string accountNumber = Console.ReadLine();

            int choice = -1;

            while (choice != 0)
            {
                Console.WriteLine("\n==============================");
                Console.WriteLine($"Account Number : {accountNumber}");
                Console.WriteLine($"Current Balance: {balance:C2}");
                Console.WriteLine("==============================");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("0. Exit");
                Console.Write("Choose an option: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Exiting Program!!!!...");
                        break;

                    case 1:
                        Console.Write("Enter deposit amount: $");
                        double depositAmount = double.Parse(Console.ReadLine());
                        balance += depositAmount;

                        Console.WriteLine("------------------------------");
                        Console.WriteLine($"Deposit Amount  : +{depositAmount:C2}");
                        Console.WriteLine($"Updated Balance : {balance:C2}");
                        break;

                    case 2:
                        Console.Write("Enter withdraw amount: $");
                        double withdrawAmount = double.Parse(Console.ReadLine());

                        if (withdrawAmount <= balance)
                        {
                            balance -= withdrawAmount;
                            Console.WriteLine("------------------------------");
                            Console.WriteLine($"Withdraw Amount : -{withdrawAmount:C2}");
                            Console.WriteLine($"Updated Balance : {balance:C2}");
                        }
                        else
                        {
                            Console.WriteLine("------------------------------");
                            Console.WriteLine("Transaction Failed: Insufficient funds!");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid option selected! Please try again.");
                        break;
                }
            }
        }
    }
}