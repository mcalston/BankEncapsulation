using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount();

            Console.WriteLine("How much $ would you like to deposit?");
            double amountToDeposit = double.Parse(Console.ReadLine());

            ba.Deposit(amountToDeposit);

            double userBalance = ba.GetBalance();

            Console.WriteLine($"Your current balace is: {userBalance,0:c}");

            
                
        }
    }
}
