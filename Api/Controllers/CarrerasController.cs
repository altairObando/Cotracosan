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
    public class CarrerasController : ControllerBase
    {
        private readonly Context _context;

        public CarrerasController(Context context)
        {
            _context = context;
        }

        // GET: api/Carreras
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Carreras>>> GetCarreras()
        {
            return await _context.Carreras.ToListAsync();
        }

        // GET: api/Carreras/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Carreras>> GetCarreras(int id)
        {
            var carreras = await _context.Carreras.FindAsync(id);

            if (carreras == null)
            {
                return NotFound();
            }

            return carreras;
        }

        // PUT: api/Carreras/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarreras(int id, Carreras carreras)
        {
            if (id != carreras.Id)
            {
                return BadRequest();
            }

            _context.Entry(carreras).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarrerasExists(id))
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

        // POST: api/Carreras
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Carreras>> PostCarreras(Carreras carreras)
        {
            _context.Carreras.Add(carreras);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCarreras", new { id = carreras.Id }, carreras);
        }

        // DELETE: api/Carreras/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Carreras>> DeleteCarreras(int id)
        {
            var carreras = await _context.Carreras.FindAsync(id);
            if (carreras == null)
            {
                return NotFound();
            }

            _context.Carreras.Remove(carreras);
            await _context.SaveChangesAsync();

            return carreras;
        }

        private bool CarrerasExists(int id)
        {
            return _context.Carreras.Any(e => e.Id == id);
        }
    }
}
