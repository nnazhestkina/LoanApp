using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Loan.Models
{
    public class BusinessInfoModel
    {
        public int BusinessInfoId { get; set; }

        [Required]
        [Display(Name = "Business Name")]
        [DataType(DataType.Text)]
        [MaxLength(60)]
        public string BusinessName { get; set; }

        [Display(Name = "Address")]
        [DataType(DataType.Text)]
        [MaxLength(60)]
        public string Address { get; set; }

        [Display(Name = "City")]
        [DataType(DataType.Text)]
        [MaxLength(60)]
        public string City { get; set; }

        [Display(Name = "State")]
        [DataType(DataType.Text)]
        [MaxLength(60)]
        public string State { get; set; }

        [Display(Name = "Phone Number")]
        [Phone(ErrorMessage = "Phone number is not valid. Please check your entry.")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        public string BusinessPhoneNumber { get; set; }

        [Display(Name = "Zip Code")]
        [Phone(ErrorMessage = "Zip code is not valid. Please check your entry.")]
        [DataType(DataType.PostalCode)]
        public int ZipCode { get; set; }

        public int LoanId { get; set; }
        public int CustomerId { get; set; }
  
    }
}
