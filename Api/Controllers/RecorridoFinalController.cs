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
    public class RecorridoFinalController : ControllerBase
    {
        private readonly Context _context;

        public RecorridoFinalController(Context context)
        {
            _context = context;
        }

        // GET: api/RecorridoFinal
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LugaresFinalesDelosRecorridos>>> GetLugaresFinalesDelosRecorridos()
        {
            return await _context.LugaresFinalesDelosRecorridos.ToListAsync();
        }

        // GET: api/RecorridoFinal/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LugaresFinalesDelosRecorridos>> GetLugaresFinalesDelosRecorridos(int id)
        {
            var lugaresFinalesDelosRecorridos = await _context.LugaresFinalesDelosRecorridos.FindAsync(id);

            if (lugaresFinalesDelosRecorridos == null)
            {
                return NotFound();
            }

            return lugaresFinalesDelosRecorridos;
        }

        // PUT: api/RecorridoFinal/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLugaresFinalesDelosRecorridos(int id, LugaresFinalesDelosRecorridos lugaresFinalesDelosRecorridos)
        {
            if (id != lugaresFinalesDelosRecorridos.Id)
            {
                return BadRequest();
            }

            _context.Entry(lugaresFinalesDelosRecorridos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LugaresFinalesDelosRecorridosExists(id))
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

        // POST: api/RecorridoFinal
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<LugaresFinalesDelosRecorridos>> PostLugaresFinalesDelosRecorridos(LugaresFinalesDelosRecorridos lugaresFinalesDelosRecorridos)
        {
            _context.LugaresFinalesDelosRecorridos.Add(lugaresFinalesDelosRecorridos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLugaresFinalesDelosRecorridos", new { id = lugaresFinalesDelosRecorridos.Id }, lugaresFinalesDelosRecorridos);
        }

        // DELETE: api/RecorridoFinal/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LugaresFinalesDelosRecorridos>> DeleteLugaresFinalesDelosRecorridos(int id)
        {
            var lugaresFinalesDelosRecorridos = await _context.LugaresFinalesDelosRecorridos.FindAsync(id);
            if (lugaresFinalesDelosRecorridos == null)
            {
                return NotFound();
            }

            _context.LugaresFinalesDelosRecorridos.Remove(lugaresFinalesDelosRecorridos);
            await _context.SaveChangesAsync();

            return lugaresFinalesDelosRecorridos;
        }

        private bool LugaresFinalesDelosRecorridosExists(int id)
        {
            return _context.LugaresFinalesDelosRecorridos.Any(e => e.Id == id);
        }
    }
}
