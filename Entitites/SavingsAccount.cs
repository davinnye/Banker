namespace Banker.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int accountNumber, string holder, double balance, double interestRate) : base(accountNumber, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdatedBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
        //overrides the Withdraw method, adding an extra fee to the Savings Account withdraw.
    }
}
