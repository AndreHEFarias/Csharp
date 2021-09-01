

namespace Heranca.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }
    
        public BusinessAccount()
        {

        }

        public BusinessAccount(int number, double balance, string holder, double loanLimit): base(number,balance,holder)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            Balance += amount;
        }
    }
}
