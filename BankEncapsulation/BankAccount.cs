using System;

namespace BankEncapsulation
{
public class BankAccount
    {
        private double balance;

        //public BankAccount(double amount)
        //{
        //    balance = amount;
        //}

        public void Deposit(double amount)
        {
            Console.WriteLine($"Simulating a deposit of {amount,0:c} to your account...");
            balance = amount;
        }

        public double GetBalance()
        {
            return balance;
        }
    }
    
}
