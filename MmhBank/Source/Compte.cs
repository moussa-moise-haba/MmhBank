using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmhBank.Source
{
    public class Compte
    {
        protected int AccountNumber { get; set; }
        protected double InterestRate { get; set; }
        protected double Balance { get; set; }
        protected string Description { get; set; }


        public Compte()
        {

        }

        public Compte(int accountNumber,double interestRate,double balance,string description)
        {
            AccountNumber = accountNumber;
            InterestRate = interestRate;
            Balance = balance;
            Description = description;

        }

        public Compte(int accountNumber, double interestRate, string description)
        {
            AccountNumber = accountNumber;
            InterestRate = interestRate;
            Description = description;
        }
    }
}
