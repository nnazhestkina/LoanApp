using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BusinessModels;
using LoanAPI.Utilitties;

namespace LoanAPI.Data
{
    public class LoanAPIContext : DbContext
    {
        public LoanAPIContext (DbContextOptions<LoanAPIContext> options)
            : base(options)
        {
          
        }

        public DbSet<BusinessModels.BusinessInfo> BusinessInfo { get; set; }

        public DbSet<BusinessModels.Customer> Customer { get; set; }

        public DbSet<BusinessModels.Loan> Loan { get; set; }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region PostSeed
            //add customer
            for (int i = 1; i < Constants.SEED_NUMBER + 1; i++)
            {
                var customer = new Customer()
                {
                    CustomerId = i,
                    FirstName = "Jane " + i,
                    LastName = "Doe " + i,
                    Address = "Street " + i,
                    City = "City " + i,
                    State = "PA",
                    ZipCode = new Random().Next(10000, 100000),   
                    PhoneNumber = Utilitties.Utilities.GetRandomPhoneNumber()
                };

                modelBuilder.Entity<Customer>().HasData(customer);
            }

            //add business
            for (int i = 1; i < Constants.SEED_NUMBER + 1; i++)
            {
                var business = new BusinessInfo()
                {
                    BusinessInfoId = i,
                    Address = "Business Street " + i,
                    BusinessName = "Business Name " + i,
                    City = "Business City " + i,
                    State = "PA",
                    ZipCode = new Random().Next(10000, 100000),
                    PhoneNumber = Utilitties.Utilities.GetRandomPhoneNumber()
                };
                modelBuilder.Entity<BusinessInfo>().HasData(business);
            }

            // add loan
            for (int i = 1; i < Constants.SEED_NUMBER + 1; i++)
            {                
                var loan = new Loan()
                {
                    LoanId = i,
                    AmountRequested = new Random().Next(10000, 700000),
                    CreditRating = new Random().Next(600, 751),
                    APR = new Random().Next(4, 12),
                    NumberOfDefaults = new Random().Next(0, 6),
                    PaybackMonths = new Random().Next(0, 100),
                    TotalOutstandingDebt = new Random().Next(25000, 1000000),
                    CustomerId = new Random().Next(1, Constants.SEED_NUMBER + 1),
                    BusinessInfoId = new Random().Next(1, Constants.SEED_NUMBER + 1),
                    IsDraft = false
                };          

                loan.RiskRating = Utilities.CalculateRiskRating(loan);//todo: calculate this
                modelBuilder.Entity<Loan>().HasData(loan);
            }

          
            #endregion
        } 
     
    }
}
