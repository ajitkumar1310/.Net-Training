using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticType_Bank
{
    class BankAccount
    {
        public static float interestrate;
        private int accountno;
        public int _accountno
        {
            get
            {
                return accountno;
            }
            set
            {
                accountno = value;
            }

        }
        
        public static float GetInterestRate()
        {
            return interestrate;
        }
        public static void SetInterestRate(float _interestrate)
        {
            interestrate = _interestrate;
        }
        static BankAccount()
        {
            interestrate = 0.12F;
        }
        //public BankAccount(string accountname, int accountno, int balance)
        //{

        //    this.accountno = accountno;
        //    this.accountname = accountname;
        //    this.balance = balance;


        //}
        

        //public float _interestrate
        //{
        //    get
        //    {
        //        return interestrate;
        //    }
        //    set
        //    {
        //        interestrate = value;
        //    }

        //}
        
        
        private string accountname;
        public string _accountname
        {
            get
            {
                return accountname;
            }
            set
            {
                accountname = value;
            }

        }
        private int balance;
        public int _balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }

        }

        public BankAccount(string accountname,int accountno, int balance)
        {
            
            this.accountno = accountno;
            this.accountname = accountname;
            this.balance = balance;
            

        }

        public void WithDraw(int amount)
        {
            if(balance>0)
            {
                if((balance - amount)>0)
                {
                    balance = balance - amount;
                }
                else
                {
                    Console.WriteLine("You dont have enough funds to withdraw");
                }
            }
            else
            {
                Console.WriteLine("You dont have enough funds to withdraw");
            }
           
        }
        public void Deposit(int amount)
        {

            balance = balance + amount;
        }

        public void DisplayBalance()
        {
            Console.WriteLine("Your Balance is "+balance);
        }


    }
}
