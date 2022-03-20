using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static Loan.App_Code.Utilities;

namespace Loan.Models
{
    public class CustomerModel
    {       
        public int CustomerId { get; set; }

        [Required (ErrorMessage = "First Name is required.")]
        [Display(Name = "First Name")]
        [DataType(DataType.Text)]
        [MaxLength(60)]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Last Name is required.")]
        [Display(Name = "Last Name")]
        [DataType(DataType.Text)]
        [MaxLength(60)]
        public string LastName { get; set; }

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
        public IEnumerable<SelectListItem> States { get; set; }

        [Display(Name = "Zip Code")]
        [Phone(ErrorMessage = "Zip code is not valid. Please check your entry.")]
        [DataType(DataType.PostalCode)]
        public int ZipCode { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        [Phone(ErrorMessage = "Phone number is not valid. Please check your entry.")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid Phone number")]
        public string PhoneNumber { get; set; }
        public int BusinessInfoId { get; set; }
        public int LoanId { get; set; }



    }
}
