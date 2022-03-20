using BusinessModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Loan.Models
{
    public class LoanApplicationsModel
    {
        public int ID { get; set; } = 0;   
        public string Name { get; set; }       
        public string BusinessName { get; set; }
        public string BusinessPhone { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        [Display(Name = "Amount Requested")]
        public int LoanAmmount { get; set; }
        public int APR { get; set; }
        public int PageCount { get; set; }
        public int PageNumber { get; set; }
        public int CustomerId { get; set; }
        public int BusinessInfoId { get; set; }
    }
}
