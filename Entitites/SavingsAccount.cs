namespace Banker.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int accountNumber, string holder, double balance, double interestRate, double withdrawlimit) : base(accountNumber, holder, balance, withdrawlimit)
        {
            InterestRate = interestRate;
        }

        
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
            return;
        }
        //overrides the Withdraw method, adding an extra fee to the Savings Account withdraw.
    }
}
