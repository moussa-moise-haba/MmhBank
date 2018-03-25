using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmhBank.Source
{
   
    
    public class Cheque:Compte
    {

        
        protected int NumberOfTransactions { get; set; }
        protected double InterestRateMinimum { get; set; }

       
        public Cheque(int accountNumber,double interestRate,
            int numberOfTransactions,
            double interestRateMinimum,
            string description)
            :base(accountNumber,interestRate, description)
        {
           
           
            NumberOfTransactions = numberOfTransactions;
            InterestRateMinimum = interestRateMinimum = 0.01;
           
        }

       

        public double CalculateInteret(double interestRate,double solde)
        {
            return 0;
        }
   


    }
}
