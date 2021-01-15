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
    public class SociosController : ControllerBase
    {
        private readonly Context _context;

        public SociosController(Context context)
        {
            _context = context;
        }

        // GET: api/Socios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Socios>>> GetSocios()
        {
            return await _context.Socios.ToListAsync();
        }

        // GET: api/Socios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Socios>> GetSocios(int id)
        {
            var socios = await _context.Socios.FindAsync(id);

            if (socios == null)
            {
                return NotFound();
            }

            return socios;
        }

        // PUT: api/Socios/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSocios(int id, Socios socios)
        {
            if (id != socios.Id)
            {
                return BadRequest();
            }

            _context.Entry(socios).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SociosExists(id))
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

        // POST: api/Socios
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Socios>> PostSocios(Socios socios)
        {
            _context.Socios.Add(socios);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSocios", new { id = socios.Id }, socios);
        }

        // DELETE: api/Socios/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Socios>> DeleteSocios(int id)
        {
            var socios = await _context.Socios.FindAsync(id);
            if (socios == null)
            {
                return NotFound();
            }

            _context.Socios.Remove(socios);
            await _context.SaveChangesAsync();

            return socios;
        }

        private bool SociosExists(int id)
        {
            return _context.Socios.Any(e => e.Id == id);
        }
    }
}
