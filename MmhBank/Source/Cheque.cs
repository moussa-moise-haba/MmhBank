using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmhBank.Source
{
   
    //The Compte Cheque module and his differents properties
    /
    public class Cheque:Account
    {

        
        protected int NumberOfTransactions { get; set; }
        protected double InterestRateMinimum { get; set; }

       //This is the constructor of account cheque
        public Cheque(int accountNumber,double interestRate,
            int numberOfTransactions,
            double interestRateMinimum,
            string description)
            :base(accountNumber,interestRate, description)
        {
           
           
            NumberOfTransactions = numberOfTransactions;
            InterestRateMinimum = interestRateMinimum = 0.01;
           
        }

       
        //This method will hep us to calculate the Interest
        public double CalculateInteret(double _interestRate,double _solde)
        {

            double interest = 0;
            if (this.Balance >= 0)
            {
                interest = 0;
            }
            else if (NumberOfTransactions <= 10)
            {
                interest = Balance * 0.001;
            }
            else if (NumberOfTransactions <= 11 || NumberOfTransactions <= 25)
            {
                interest = Balance * _interestRate*0.4;
            }
            else if(NumberOfTransactions <= 26 || NumberOfTransactions <= 35)
            {
                interest = Balance * _interestRate*0.8;
            }
            else if(NumberOfTransactions > 35)
            {
                interest = Balance * _interestRate;
            }

            return interest;

            
        }
   


    }
}
