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
    public class PenalizacionesController : ControllerBase
    {
        private readonly Context _context;

        public PenalizacionesController(Context context)
        {
            _context = context;
        }

        // GET: api/Penalizaciones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Penalizaciones>>> GetPenalizaciones()
        {
            return await _context.Penalizaciones.ToListAsync();
        }

        // GET: api/Penalizaciones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Penalizaciones>> GetPenalizaciones(int id)
        {
            var penalizaciones = await _context.Penalizaciones.FindAsync(id);

            if (penalizaciones == null)
            {
                return NotFound();
            }

            return penalizaciones;
        }

        // PUT: api/Penalizaciones/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPenalizaciones(int id, Penalizaciones penalizaciones)
        {
            if (id != penalizaciones.Id)
            {
                return BadRequest();
            }

            _context.Entry(penalizaciones).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PenalizacionesExists(id))
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

        // POST: api/Penalizaciones
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Penalizaciones>> PostPenalizaciones(Penalizaciones penalizaciones)
        {
            _context.Penalizaciones.Add(penalizaciones);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPenalizaciones", new { id = penalizaciones.Id }, penalizaciones);
        }

        // DELETE: api/Penalizaciones/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Penalizaciones>> DeletePenalizaciones(int id)
        {
            var penalizaciones = await _context.Penalizaciones.FindAsync(id);
            if (penalizaciones == null)
            {
                return NotFound();
            }

            _context.Penalizaciones.Remove(penalizaciones);
            await _context.SaveChangesAsync();

            return penalizaciones;
        }

        private bool PenalizacionesExists(int id)
        {
            return _context.Penalizaciones.Any(e => e.Id == id);
        }
    }
}
