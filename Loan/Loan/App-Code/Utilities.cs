using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loan.App_Code
{
    public class Utilities
    {
        internal static SelectList GetStates()
        {
            List<SelectListItem> statesItemList = new List<SelectListItem>();
            statesItemList.Add(new SelectListItem() { Text = "PA", Value = "PA" });
            statesItemList.Add(new SelectListItem() { Text = "NJ", Value = "NJ" });
            statesItemList.Add(new SelectListItem() { Text = "NY", Value = "NY" });
            statesItemList.Add(new SelectListItem() { Text = "HW", Value = "HW" });
            return new SelectList(statesItemList, "Value", "Text");
        }

        public enum EditAction
        {
            edit_record,
            new_record
        }

        internal static SortedList<string, string> GetSearchBy()
        {
            var s = new SortedList<string, string>();
            s.Add("LastName", "Last Name");
            s.Add("AmountRequested", "Amount Requested");
            s.Add("BusinessName", "Business Name");
            s.Add("CreditRating", "Credit Rating");
            s.Add("RiskRating", "Risk Rating");
            s.Add("NumberOfDefaults", "Number of Defaults");
            s.Add("PhoneNumber", "Phone Number");
            return s;
        }

       
        internal static EnumTableName GetTableName(string column) =>
            column switch { 
                "LastName"=> EnumTableName.Customer,
                "BusinessName" => EnumTableName.BusinessInfo,
                _ => EnumTableName.Loan
            };

      

        public enum EnumTableName {
            Customer,
            Loan,
            BusinessInfo
        }

        public enum NextBack {next, back }

        public const int PAGE_SIZE = 12;

    }
}

