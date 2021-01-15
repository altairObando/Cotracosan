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
    public class TurnosController : ControllerBase
    {
        private readonly Context _context;

        public TurnosController(Context context)
        {
            _context = context;
        }

        // GET: api/Turnos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Turnos>>> GetTurnos()
        {
            return await _context.Turnos.ToListAsync();
        }

        // GET: api/Turnos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Turnos>> GetTurnos(int id)
        {
            var turnos = await _context.Turnos.FindAsync(id);

            if (turnos == null)
            {
                return NotFound();
            }

            return turnos;
        }

        // PUT: api/Turnos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTurnos(int id, Turnos turnos)
        {
            if (id != turnos.Id)
            {
                return BadRequest();
            }

            _context.Entry(turnos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TurnosExists(id))
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

        // POST: api/Turnos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Turnos>> PostTurnos(Turnos turnos)
        {
            _context.Turnos.Add(turnos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTurnos", new { id = turnos.Id }, turnos);
        }

        // DELETE: api/Turnos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Turnos>> DeleteTurnos(int id)
        {
            var turnos = await _context.Turnos.FindAsync(id);
            if (turnos == null)
            {
                return NotFound();
            }

            _context.Turnos.Remove(turnos);
            await _context.SaveChangesAsync();

            return turnos;
        }

        private bool TurnosExists(int id)
        {
            return _context.Turnos.Any(e => e.Id == id);
        }
    }
}
