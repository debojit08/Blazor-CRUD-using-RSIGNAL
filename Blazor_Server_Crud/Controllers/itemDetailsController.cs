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
    public class itemDetailsController : ControllerBase
    {
        private readonly empDbContext _context;

        public itemDetailsController(empDbContext context)
        {
            _context = context;
        }

        // GET: api/itemDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<itemDetail>>> GetitemDetailTable()
        {
            return await _context.itemDetailTable.ToListAsync();
        }

        // GET: api/itemDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<itemDetail>> GetitemDetail(int id)
        {
            var itemDetail = await _context.itemDetailTable.FindAsync(id);

            if (itemDetail == null)
            {
                return NotFound();
            }

            return itemDetail;
        }

        // PUT: api/itemDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutitemDetail(int id, itemDetail itemDetail)
        {
            if (id != itemDetail.itemId)
            {
                return BadRequest();
            }

            _context.Entry(itemDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!itemDetailExists(id))
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

        // POST: api/itemDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<itemDetail>> PostitemDetail(itemDetail itemDetail)
        {
            _context.itemDetailTable.Add(itemDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetitemDetail", new { id = itemDetail.itemId }, itemDetail);
        }

        // DELETE: api/itemDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteitemDetail(int id)
        {
            var itemDetail = await _context.itemDetailTable.FindAsync(id);
            if (itemDetail == null)
            {
                return NotFound();
            }

            _context.itemDetailTable.Remove(itemDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool itemDetailExists(int id)
        {
            return _context.itemDetailTable.Any(e => e.itemId == id);
        }
    }
}
