using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api.Models;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AbonosController : ControllerBase
    {
        private readonly Context _context;

        public AbonosController(Context context)
        {
            _context = context;
        }

        // GET: api/Abonos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Abonos>>> GetAbonos()
        {
            return await _context.Abonos.ToListAsync();
        }

        // GET: api/Abonos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Abonos>> GetAbonos(int id)
        {
            var abonos = await _context.Abonos.FindAsync(id);

            if (abonos == null)
            {
                return NotFound();
            }

            return abonos;
        }

        // PUT: api/Abonos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAbonos(int id, Abonos abonos)
        {
            if (id != abonos.Id)
            {
                return BadRequest();
            }

            _context.Entry(abonos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AbonosExists(id))
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

        // POST: api/Abonos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Abonos>> PostAbonos(Abonos abonos)
        {
            _context.Abonos.Add(abonos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAbonos", new { id = abonos.Id }, abonos);
        }

        // DELETE: api/Abonos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Abonos>> DeleteAbonos(int id)
        {
            var abonos = await _context.Abonos.FindAsync(id);
            if (abonos == null)
            {
                return NotFound();
            }

            _context.Abonos.Remove(abonos);
            await _context.SaveChangesAsync();

            return abonos;
        }

        private bool AbonosExists(int id)
        {
            return _context.Abonos.Any(e => e.Id == id);
        }
    }
}
