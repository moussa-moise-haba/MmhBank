using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmhBank.Source
{
   
    
    public class Cheque
    {
        public Cheque(int compteNumber,
                        double interestRate, 
                        int numberOfTransactions, 
                        double interestRateMinimum,
                        string description)
        {
            this.CompteNumber = compteNumber;
            this.InterestRate = interestRate;
            this.NumberOfTransactions = numberOfTransactions;
            this.InterestRateMinimum = interestRateMinimum = 0.01;
            this.Description = description;
        }

        public int CompteNumber { get; set; }
        public double InterestRate { get; set; }

        public int NumberOfTransactions { get; set; }
        public double InterestRateMinimum { get; set; }

        public string Description { get; set; }

        public double CalculateInteret(double interestRate,double solde)
        {
            return 0;
        }
   


    }
}
