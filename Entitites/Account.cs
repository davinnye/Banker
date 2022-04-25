using Banker.Entities.Exceptions;

namespace Banker.Entities
{
    abstract class Account
    {
        public int AccountNumber { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(int accountNumber, string holder, double balance, double withdrawlimit)
        {
            AccountNumber = accountNumber;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawlimit;
        }

        public virtual void Withdraw(double amount)
        {
            if (Balance - amount < 0.0)
            {
                throw new DomainException("Withdraw error: Insuficient balance");
            }
            // if the client tries to withdraw more money than they have, the action won't be allowed and it will show the error message instead.
            
            Balance -= amount;
            return;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
