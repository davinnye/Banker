using System;
using System.Globalization;
using Banker.Entities.Exceptions;
using Banker.Entities;


namespace Banker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
                //the program will try to pass the code
            {
                Console.Write("Is it a Savings account or a Business account? (S/B)");
                char verify = char.Parse(Console.ReadLine());

                if (verify == 's' || verify == 'S')
                {
                    Console.WriteLine("Enter account data");
                    Console.Write("Number: ");
                    int accountNumber = int.Parse(Console.ReadLine());
                    Console.Write("Holder: ");
                    string holder = Console.ReadLine();
                    Console.Write("Initial deposit: ");
                    double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Interest rate: ");
                    double interestRate = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Withdraw limit: ");
                    double withdrawlimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    SavingsAccount savingsAccount = new SavingsAccount(accountNumber, holder, balance, interestRate, withdrawlimit);
                    Console.WriteLine();
                    Console.Write("Enter amount to be withdrawn: ");
                    double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    savingsAccount.Withdraw(withdraw);
                    Console.WriteLine($"New balance: {savingsAccount.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
                }

                else if (verify == 'b' || verify == 'B')
                {
                    Console.WriteLine("Enter account data");
                    Console.Write("Number: ");
                    int accountNumber = int.Parse(Console.ReadLine());
                    Console.Write("Holder: ");
                    string holder = Console.ReadLine();
                    Console.Write("Initial deposit: ");
                    double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Loan limit: ");
                    double loan = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Withdraw limit: ");
                    double withdrawlimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    BusinessAccount business = new BusinessAccount(accountNumber, holder, balance, loan, withdrawlimit);
                    Console.WriteLine();
                    Console.Write("Enter amount to be withdrawn: ");
                    double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    business.Withdraw(withdraw);
                    Console.WriteLine($"New balance: {business.Balance.ToString("F2", CultureInfo.InvariantCulture)}");

                }

                else
                {
                    throw new DomainException("Error: Type of account could not be identified.");
                }


            }
            // if any exception happen, then the program will print it based on the possibilities below:
            catch (FormatException e)
            {
                Console.WriteLine($"Error in format: {e.Message}");
            }
            catch (DomainException e)
            {
                Console.WriteLine($"{e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected error: {e.Message}");
            }



        }
    }
}
