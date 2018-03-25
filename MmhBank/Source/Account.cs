using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmhBank.Source
{
    public class Account
    {
        //Declaration of differents properties
        protected int AccountNumber { get; set; }
        protected double InterestRate { get; set; }
        protected double Balance { get; set; }
        protected string Description { get; set; }

        //Default constructor
        public Account()
        {

        }

        //first constructor
        public Account(int accountNumber,double interestRate,double balance,string description)
        {
            AccountNumber = accountNumber;
            InterestRate = interestRate;
            Balance = balance;
            Description = description;

        }
        //third constructor
        public Account(int accountNumber, double interestRate, string description)
        {
            AccountNumber = accountNumber;
            InterestRate = interestRate;
            Description = description;
        }
    }
}
