namespace Course.Inherit.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount() { }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) 
            : base(number, holder, balance)
        {
            this.LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= this.LoanLimit)
            {
                this.Balance += amount;
            }
        }
    }
}
