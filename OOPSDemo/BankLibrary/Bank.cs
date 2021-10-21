using System;

namespace BankLibrary
{
    public abstract class Bank
    {

        #region Field & Properties


        private string accHolderName;

        public string AccHolderName
        {
            get { return accHolderName; }
            set { accHolderName = value; }

        }

        public double balance;

        public double Balance
        {
            get { return balance; }
          protected  set { balance = value; }

        }
        

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public abstract void Withdraw(double amount);


        /*public  virtual void Withdraw(double amount)
        {
            Balance -= amount;
        }
        */

        public override string ToString()
        {    //traditional
             //return "AccoundHolderName:" + accHolderName + "Balance:" + Balance;

           // fromated string
            return string.Format("AccountHolderName : {0} Balance : {1}", accHolderName, Balance);

            //string interpolation
           // return string.Format($"Account Holder Name:{accHolderName} Balance :{Balance}");
        }
        #endregion


        #region Constructor

        public Bank()
        {
            Balance = 1000;
        }
        public Bank(string name,double amount)
        {
            this.AccHolderName = name;
            this.Balance = amount;
        }
        #endregion

    }
}
