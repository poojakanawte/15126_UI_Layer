namespace BankLibrary
{
    public  class Savings : Bank,IInterest
    {
       public Savings()
        {

        }
        public Savings(string name,double amt):base(name,amt)
        {

        }

        public double CalculateInterest()
        {
            return Balance * .1;
        }

        public sealed override void Withdraw(double amount)
        {
           if((Balance-amount)> 0)
                    {
                Balance -= amount;
            }
           else
            {
                throw new BalanceException("Balance not Enough.cannot withdraw");
            }
        }
    }
    
}
