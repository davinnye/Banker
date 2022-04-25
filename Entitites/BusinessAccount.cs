using Banker.Entities.Exceptions;

namespace Banker.Entities
{
    internal class BusinessAccount : Account
    //BusinessAccount inherits Account's characteristics
    {
        public double LoanLimit { get; set; }

        public BusinessAccount() { }

        public BusinessAccount(int accountNumber, string holder, double balance, double loanLimit) : base(accountNumber, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
            else
            {
                throw new DomainException("Loan error: Amount requested is higher than allowed");
            }
            //it will test if the solicited loan is possible, in case it isn't, the amount won't be changed and an error will be informed to the user.
        }
    }
}
