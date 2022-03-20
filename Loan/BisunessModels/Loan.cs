using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessModels
{
   public class Loan
    {
        [Column("LoanId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int LoanId { get; set; }      
        public int AmountRequested { get; set; }      
        public int PaybackMonths { get; set; }       
        public int APR { get; set; }
        public int CreditRating { get; set; }
        public int NumberOfDefaults { get; set; }
        public int TotalOutstandingDebt { get; set; }
        public int RiskRating { get; set; }//calculate this

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey("BusinessInfo")]
        public int BusinessInfoId { get; set; }
        public BusinessInfo BusinessInfo { get; set; }

        public bool IsDraft { get; set; } = true;
    }
}
