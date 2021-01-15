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
    public class CreditosController : ControllerBase
    {
        private readonly Context _context;

        public CreditosController(Context context)
        {
            _context = context;
        }

        // GET: api/Creditos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Creditos>>> GetCreditos()
        {
            return await _context.Creditos.ToListAsync();
        }

        // GET: api/Creditos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Creditos>> GetCreditos(int id)
        {
            var creditos = await _context.Creditos.FindAsync(id);

            if (creditos == null)
            {
                return NotFound();
            }

            return creditos;
        }

        // PUT: api/Creditos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCreditos(int id, Creditos creditos)
        {
            if (id != creditos.Id)
            {
                return BadRequest();
            }

            _context.Entry(creditos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CreditosExists(id))
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

        // POST: api/Creditos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Creditos>> PostCreditos(Creditos creditos)
        {
            _context.Creditos.Add(creditos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCreditos", new { id = creditos.Id }, creditos);
        }

        // DELETE: api/Creditos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Creditos>> DeleteCreditos(int id)
        {
            var creditos = await _context.Creditos.FindAsync(id);
            if (creditos == null)
            {
                return NotFound();
            }

            _context.Creditos.Remove(creditos);
            await _context.SaveChangesAsync();

            return creditos;
        }

        private bool CreditosExists(int id)
        {
            return _context.Creditos.Any(e => e.Id == id);
        }
    }
}
