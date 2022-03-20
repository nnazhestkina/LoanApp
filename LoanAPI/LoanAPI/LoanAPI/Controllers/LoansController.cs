using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessModels;
using LoanAPI.Data;

namespace LoanAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoansController : ControllerBase
    {
        private readonly LoanAPIContext _context;

        public LoansController(LoanAPIContext context)
        {
            _context = context;

        }

        // GET: api/Loans
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Loan>>> GetLoan()
        {
            return await _context.Loan
        .Join(
            _context.Customer,
            loan => loan.CustomerId,
            customer => customer.CustomerId,
            (loan, customer) => new { L = loan, C = customer }

        ).Join(
            _context.BusinessInfo,
            loan => loan.L.BusinessInfoId,
            business => business.BusinessInfoId,
            (loan, business) => new { L = loan, B = business }

        ).Select(x => new Loan()
        {
            LoanId = x.L.L.LoanId,
            AmountRequested = x.L.L.AmountRequested,
            PaybackMonths = x.L.L.PaybackMonths,
            APR = x.L.L.APR,
            CreditRating = x.L.L.CreditRating,
            NumberOfDefaults = x.L.L.NumberOfDefaults,
            TotalOutstandingDebt = x.L.L.TotalOutstandingDebt,
            RiskRating = x.L.L.RiskRating,
            CustomerId = x.L.L.CustomerId,
            Customer = x.L.C,
            BusinessInfoId = x.B.BusinessInfoId,
            BusinessInfo = x.B,
            IsDraft = x.L.L.IsDraft

        }).Where(l=>l.IsDraft == false).OrderBy(n=>n.Customer.FirstName).OrderBy(n => n.Customer.LastName).ToListAsync<Loan>();

        }

        //// GET: api/Loans
        [HttpGet("{table}/{column}/{searchString}")]
        public async Task<ActionResult<IEnumerable<Loan>>> GetLoan(string table, string column, string searchString)
        {
            searchString = searchString.Replace("'", "''");

            string sql = @"select loan.* from  Loan 
inner join customer   on customer.CustomerId = Loan.CustomerId
inner join BusinessInfo  on BusinessInfo.BusinessInfoId = Loan.BusinessInfoId 
where loan.isdraft =0 and " + table + "." + column + " like '%" + searchString + "%' order by  customer.lastname, customer.firstname";

            var loans = await _context.Loan.FromSqlRaw<Loan>(sql).ToListAsync();
            foreach (var loan in loans)
            {
                loan.Customer = _context.Customer.Where(c => c.CustomerId == loan.CustomerId).FirstOrDefault();
                loan.BusinessInfo = _context.BusinessInfo.Where(b => b.BusinessInfoId == loan.BusinessInfoId).FirstOrDefault();
            }
            if (loans == null)
            {
                return NotFound();
            }

            return loans;

        }

        // GET: api/Loans/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Loan>> GetLoan(int id)
        {
            var loan = await _context.Loan.FindAsync(id);
            loan.Customer = _context.Customer.Where(c => c.CustomerId == loan.CustomerId).FirstOrDefault();
            loan.BusinessInfo = _context.BusinessInfo.Where(b => b.BusinessInfoId == loan.BusinessInfoId).FirstOrDefault();
            if (loan == null)
            {
                return NotFound();
            }

            return loan;
        }

        // PUT: api/Loans/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLoan(int id, Loan loan)
        {
            if (id != loan.LoanId)
            {
                return BadRequest();
            }

            _context.Entry(loan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoanExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Loans
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Loan>> PostLoan(Loan loan)
        {
            _context.Loan.Add(loan);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLoan", new { id = loan.LoanId }, loan);
        }

        // DELETE: api/Loans/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLoan(int id)
        {
            var loan = await _context.Loan.FindAsync(id);
            if (loan == null)
            {
                return NotFound();
            }

            _context.Loan.Remove(loan);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LoanExists(int id)
        {
            return _context.Loan.Any(e => e.LoanId == id);
        }


    }
}
