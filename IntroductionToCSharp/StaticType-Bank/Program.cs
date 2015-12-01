using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticType_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
           
            BankAccount.GetInterestRate();
            Console.WriteLine(BankAccount.GetInterestRate());
         //   BankAccount.interestrate = 0.15F;
            BankAccount b = new BankAccount("Abhinav",0001,500);
            BankAccount.interestrate = 0.15F;
            BankAccount b2 = new BankAccount("Abhinav", 0001, 500);
            Console.WriteLine(b._accountname);
            Console.WriteLine(b._accountno);
            Console.WriteLine(b._balance);
            Console.WriteLine(BankAccount.GetInterestRate());
            BankAccount.interestrate = 0.15F;
            Console.WriteLine(BankAccount.GetInterestRate());
            BankAccount.SetInterestRate(0.25F);
            Console.WriteLine(BankAccount.GetInterestRate());

            b.DisplayBalance();
           
            b.WithDraw(100);
            b.DisplayBalance();
            b.Deposit(200);
            b.DisplayBalance();
            BankAccount a = new BankAccount("Ajit", 0002, 600);
            int c = StaticClass.GetA();

            Console.WriteLine(c);
            StaticClass.SetA(40);
            Console.WriteLine(StaticClass.GetA());
        }
    }
}
