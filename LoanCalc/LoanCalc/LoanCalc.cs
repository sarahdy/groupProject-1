using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalc
{
    public class LoanCalc
    {
        public double payment { get; set; }
        public string name { get; set; }
        public int ssn { get; set; }
        public char typeOfLoan { get; set; }
        public char creditRating { get; set; }
        public double baseInterestRate { get; set; }
        public double downPayment{ get; set; }
        public double propertyValue { get; set; }
        public double interestRate { get; set; }
        public double loanAmount { get; set; }
        public double totalCost { get; set; }
        public double numYears { get; set;}

        public double calculateInterestRate()
        {
            if (downPayment < Math.Round((propertyValue / 10), 2))
            {
                interestRate = baseInterestRate + 0.01;

            }
            else
            {
                interestRate = baseInterestRate;
            }

            switch (creditRating)
            {
                case 'a':
                    interestRate = interestRate;
                    break;
                case 'b':
                    interestRate = interestRate + 0.01;
                    break;
                case 'c':
                    interestRate = interestRate + 0.02;
                    break;
                case 'd':
                    interestRate = interestRate + 0.3;
                    break;
            }


            switch (typeOfLoan)
            {
                case 'r':
                    interestRate = interestRate;
                    break;
                case 'b':
                    interestRate = interestRate + 0.005;
                    break;
                case 'h':
                    interestRate = interestRate + 0.01;
                    break;
                case 'e':
                    interestRate = interestRate + 0.025;
                    break;
                case 'a':
                    interestRate = interestRate + 0.035;
                    break;
            }
            return interestRate;
        }
        public double calculateTotalCost()
        {
            loanAmount = propertyValue - downPayment;
            totalCost = loanAmount + (loanAmount * interestRate)*numYears;
            return totalCost;
        }
    }
}
