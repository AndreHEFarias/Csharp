
namespace Heranca.Entities
{
    //sealed
     class SavingsAccount: Account
    {
        public double InterestRate { get; set; }
        
        public SavingsAccount()
        {

        }
        public SavingsAccount(int number, double balance, string holder, double interestRate)
            : base(number, balance, holder )
        {
            InterestRate = interestRate;
        }
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdrawn(double amount)
        {
            base.Withdrawn(amount);
            Balance -= 2.0;
        }



    }
}
