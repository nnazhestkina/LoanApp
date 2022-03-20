using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessModels;
using Loan.Models;
using X.PagedList;

namespace Loan.App_Code
{
    public class Mapper
    {

        public static IQueryable<LoanApplicationsModel> Map(List<BusinessModels.Loan> loans)
        {
            if (loans == null) return null;

            return (from m in loans select Map(m)).AsQueryable();
        }

        //public static X.PagedList.IPagedList<LoanApplicationsModel> Map(List<BusinessModels.Loan> loans)
        //{
        //    if (loans == null) return null;

        //    return (from m in loans select Map(m)).AsQueryable().ToPagedList();
        //}

        public static LoanApplicationsModel Map(BusinessModels.Loan loan)
        {
            if (loan == null) return new LoanApplicationsModel();

            return new LoanApplicationsModel() {
                ID = loan.LoanId, 
                Name = loan.Customer?.FirstName+" "+loan.Customer.LastName,
                Phone = loan.Customer?.PhoneNumber,
                Address = GetAddress(loan.Customer), 
                LoanAmmount=loan.AmountRequested, 
                APR = loan.APR,
                CustomerId = loan.CustomerId,                
                BusinessInfoId = loan.BusinessInfoId,
                BusinessName = loan.BusinessInfo.BusinessName
            };
        }

        public static LoanModel MapLoan(BusinessModels.Loan loan)
        {
            if (loan == null) return new LoanModel();

            var l = new LoanModel()
            {
                LoanId = loan.LoanId,
                APR = loan.APR,
                CustomerId = loan.CustomerId,
                BusinessInfoId = loan.BusinessInfoId,
                Customer = Map(loan.Customer),
                AmountRequested = loan.AmountRequested,
                CreditRating = loan.CreditRating,
                NumberOfDefaults = loan.NumberOfDefaults,
                PaybackMonths = loan.PaybackMonths,
                RiskRating = loan.RiskRating,
                TotalOutstandingDebt = loan.TotalOutstandingDebt,
                BusinessInfo = Map(loan.BusinessInfo),
                IsDraft = loan.IsDraft
            };

            l.BusinessInfo.CustomerId = l.CustomerId;
            l.Customer.BusinessInfoId = l.BusinessInfoId;
            l.BusinessInfo.LoanId = l.LoanId;
            l.Customer.LoanId = l.LoanId;

            return l;
        }

        public static BusinessModels.Loan MapLoan(LoanModel loan)
        {
            if (loan == null) return new BusinessModels.Loan();

            return new BusinessModels.Loan()
            {
                LoanId = loan.LoanId,
                APR = loan.APR,
                CustomerId = loan.CustomerId,
                BusinessInfoId = loan.BusinessInfoId,
              
                AmountRequested = loan.AmountRequested,
                CreditRating = loan.CreditRating,
                NumberOfDefaults = loan.NumberOfDefaults,
                PaybackMonths = loan.PaybackMonths,
                RiskRating = loan.RiskRating,
                TotalOutstandingDebt = loan.TotalOutstandingDebt,
               IsDraft = loan.IsDraft

            };
        }

        public static CustomerModel Map(BusinessModels.Customer customer)
        {
            if (customer == null) return new CustomerModel();

            return new CustomerModel()
            {
                CustomerId = customer.CustomerId,
                Address = customer.Address,
                City = customer.City,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                PhoneNumber = customer.PhoneNumber,
                State = customer.State,
                ZipCode = customer.ZipCode
            };
        }

        public static BusinessModels.Customer  Map(CustomerModel customer)
        {
            if (customer == null) return new BusinessModels.Customer();

            return new BusinessModels.Customer()
            {
                CustomerId = customer.CustomerId,
                Address = customer.Address,
                City = customer.City,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                PhoneNumber = customer.PhoneNumber,
                State = customer.State,
                ZipCode = customer.ZipCode
            };
        }

        public static BusinessInfoModel Map(BusinessModels.BusinessInfo business)
        {
            if (business == null) return new BusinessInfoModel();

            return new BusinessInfoModel()
            {
                BusinessInfoId = business.BusinessInfoId,
                BusinessName = business.BusinessName,
                Address = business.Address,
                City = business.City,
                BusinessPhoneNumber = business.PhoneNumber,
                State = business.State,
                ZipCode = business.ZipCode
            };
        }

        public static BusinessModels.BusinessInfo  Map(BusinessInfoModel business)
        {
            if (business == null) return new BusinessModels.BusinessInfo();

            return new BusinessModels.BusinessInfo()
            {
                BusinessInfoId = business.BusinessInfoId,
                BusinessName = business.BusinessName,
                Address = business.Address,
                City = business.City,
                PhoneNumber = business.BusinessPhoneNumber,
                State = business.State,
                ZipCode = business.ZipCode
            };
        }

        private static string GetAddress(Customer customer)
        {
            if (customer == null) return "";
            return customer.Address + ", " + customer.City ;
        }
    }
}
