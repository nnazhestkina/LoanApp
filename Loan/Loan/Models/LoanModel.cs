using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static Loan.App_Code.Utilities;

namespace Loan.Models
{
    public class LoanModel
    {
        public int LoanId { get; set; }      
        public int CustomerId { get; set; }
        public int BusinessInfoId { get; set; }
      
        [Required]
        [Display(Name = "Amount Requested")]
        [Range(typeof(int), "0", "1000000")]
        public int AmountRequested { get; set; }

        [Required]
        [Display(Name = "Payback Months")]
        [Range(typeof(int), "1", "100")]
        public int PaybackMonths { get; set; } = 1;

        [Required]
        [Display(Name = "APR")]
        [Range(typeof(int), "4", "12")]
        public int APR { get; set; }

        [Required]
        [Display(Name = "Credit Rating")]
        [Range(typeof(int), "600", "850")]
        public int CreditRating { get; set; }

        [Required]
        [Display(Name = "Number Of Defaults")]
        [Range(typeof(int), "0", "50")]
        public int NumberOfDefaults { get; set; }

        [Required]
        [Display(Name = "Total Outstanding Debt")]
        [Range(typeof(int), "0", "10000000")]
        public int TotalOutstandingDebt { get; set; }
        public int RiskRating { get; set; }//calculate this      


        public CustomerModel Customer { get; set; } = new CustomerModel();
        public BusinessInfoModel BusinessInfo { get; set; } = new BusinessInfoModel();

        public EditAction EditAction { get; set; } = EditAction.edit_record;
        public bool IsDraft { get; set; } = true;


        public bool IsCustomerViewVisible { get; set; } = false;
        public bool IsBusinessViewVisible { get; set; } = false;
        public bool IsLoanViewVisible { get; set; } = false;
    }
}
