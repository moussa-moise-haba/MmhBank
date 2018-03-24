using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmhBank.Source
{
    public class Compte
    {
        public Compte(int accountNumber,double interestRate,double balance,string description)
        {
            AccountNumber = accountNumber;
            InterestRate = interestRate;
            Balance = balance;
            Description = description;

        }
        public int AccountNumber { get; set; }
        public double InterestRate { get; set; }
        public double Balance { get; set; }
        public string Description { get; set; }
    }
}
