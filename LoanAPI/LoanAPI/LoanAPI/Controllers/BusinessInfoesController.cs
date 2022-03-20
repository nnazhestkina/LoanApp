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
    public class BusinessInfoesController : ControllerBase
    {
        private readonly LoanAPIContext _context;

        public BusinessInfoesController(LoanAPIContext context)
        {
            _context = context;
        }

        // GET: api/BusinessInfoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BusinessInfo>>> GetBusinessInfo()
        {
            return await _context.BusinessInfo.ToListAsync();
        }

        // GET: api/BusinessInfoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BusinessInfo>> GetBusinessInfo(int id)
        {
            var businessInfo = await _context.BusinessInfo.FindAsync(id);
          
            if (businessInfo == null)
            {
                return NotFound();
            }
         

            return businessInfo;
        }

        // PUT: api/BusinessInfoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBusinessInfo(int id, BusinessInfo businessInfo)
        {
            if (id != businessInfo.BusinessInfoId)
            {
                return BadRequest();
            }

            _context.Entry(businessInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BusinessInfoExists(id))
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

        // POST: api/BusinessInfoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BusinessInfo>> PostBusinessInfo(BusinessInfo businessInfo)
        {
            _context.BusinessInfo.Add(businessInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBusinessInfo", new { id = businessInfo.BusinessInfoId }, businessInfo);
        }

        // DELETE: api/BusinessInfoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBusinessInfo(int id)
        {
            var businessInfo = await _context.BusinessInfo.FindAsync(id);
            if (businessInfo == null)
            {
                return NotFound();
            }

            _context.BusinessInfo.Remove(businessInfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BusinessInfoExists(int id)
        {
            return _context.BusinessInfo.Any(e => e.BusinessInfoId == id);
        }
    }
}
