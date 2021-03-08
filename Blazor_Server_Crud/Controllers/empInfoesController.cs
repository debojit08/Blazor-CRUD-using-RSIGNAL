using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Blazor_Server_Crud.Data;
using Blazor_Server_Crud.Server.Data;

namespace Blazor_Server_Crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class empInfoesController : ControllerBase
    {
        private readonly empDbContext _context;

        public empInfoesController(empDbContext context)
        {
            _context = context;
        }

        // GET: api/empInfoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<empInfo>>> GetempTable()
        {
            return await _context.empTable.ToListAsync();
        }

        // GET: api/empInfoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<empInfo>> GetempInfo(int id)
        {
            var empInfo = await _context.empTable.FindAsync(id);

            if (empInfo == null)
            {
                return NotFound();
            }

            return empInfo;
        }

        // PUT: api/empInfoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutempInfo(int id, empInfo empInfo)
        {
            if (id != empInfo.empId)
            {
                return BadRequest();
            }

            _context.Entry(empInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!empInfoExists(id))
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

        // POST: api/empInfoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<empInfo>> PostempInfo(empInfo empInfo)
        {
            _context.empTable.Add(empInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetempInfo", new { id = empInfo.empId }, empInfo);
        }

        // DELETE: api/empInfoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteempInfo(int id)
        {
            var empInfo = await _context.empTable.FindAsync(id);
            if (empInfo == null)
            {
                return NotFound();
            }

            _context.empTable.Remove(empInfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool empInfoExists(int id)
        {
            return _context.empTable.Any(e => e.empId == id);
        }
    }
}
