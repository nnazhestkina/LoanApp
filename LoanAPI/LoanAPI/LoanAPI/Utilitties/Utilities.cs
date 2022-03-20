using BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanAPI.Utilitties
{
    public class Utilities
    {
        public static int CalculateRiskRating(Loan loan)
        {
            if (loan.CreditRating < 650) return 10;
            else if (loan.CreditRating >= 650 && loan.CreditRating < 720) return 5;
            else return 1;
        }

        public static string GetRandomPhoneNumber()
        {
            return "" + new Random().Next(111, 1000) + "-" +new Random().Next(111, 1000) + "-" + new Random().Next(1111, 10000);
        }
    }
}
