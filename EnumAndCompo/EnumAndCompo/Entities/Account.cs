

namespace Heranca.Entities
{
    class Account
    {
        public int Number { get; protected set; }
        public double Balance { get; protected set; }
        public string Holder { get; protected set; }
    
        public Account()
        {

        }

        public Account(int number, double balance, string holder)
        {
            Number = number;
            Balance = balance;
            Holder = holder;
        }

        public virtual void Withdrawn(double amount)
        {
            Balance -= amount+5.0;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
