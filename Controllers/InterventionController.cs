using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RocketElevators.Models;

namespace RocketElevators.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterventionController : ControllerBase
    {
        private readonly RocketElevatorsContext _context;

        public InterventionController(RocketElevatorsContext context)
        {
            _context = context;
        }

        // GET: api/Intervention
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Intervention>>> Getinterventions()
        {
          if (_context.interventions == null)
          {
              return NotFound();
          }
            return await _context.interventions.ToListAsync();
        }
        // Custom GET: api/InterventionList
        [HttpGet("/api/InterventionList")]
        public async Task<ActionResult<IEnumerable<Intervention>>> GetinterventionList()
        {
            if (_context.interventions == null)
            {
                return NotFound();
            }
            return await _context.interventions.Where(intervention => intervention.start_date_and_time_of_the_intervention == null && intervention.status == "Pending").ToListAsync();

        }

        // GET: api/Intervention/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Intervention>> GetIntervention(long id)
        {
          if (_context.interventions == null)
          {
              return NotFound();
          }
            var intervention = await _context.interventions.FindAsync(id);

            if (intervention == null)
            {
                return NotFound();
            }

            return intervention;
        }

        // PUT: api/Intervention/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        // [HttpPut("{id}")]
        // public async Task<IActionResult> PutIntervention(long id, Intervention intervention)
        // {
        //     if (id != intervention.Id)
        //     {
        //         return BadRequest();
        //     }

        //     _context.Entry(intervention).State = EntityState.Modified;

        //     try
        //     {
        //         await _context.SaveChangesAsync();
        //     }
        //     catch (DbUpdateConcurrencyException)
        //     {
        //         if (!InterventionExists(id))
        //         {
        //             return NotFound();
        //         }
        //         else
        //         {
        //             throw;
        //         }
        //     }

        //     return NoContent();
        // }
        // Custom: PUT START api/
        [HttpPut("{id}/Start")]
        public async Task<IActionResult> PutInterventionStart(long id)
        {
            DateTime localDate = DateTime.Now;
            var entity = _context.interventions.FirstOrDefault(intervention => intervention.Id == id);

            if (entity == null)
            {
                return BadRequest();
            }

            if (entity != null) 
            {
                entity.status = "InProgress";
                entity.start_date_and_time_of_the_intervention = localDate;
                entity.end_date_and_time_of_the_intervention = null;
                _context.SaveChanges();
            }
            // _context.Entry(intervention).State = EntityState.Modified;//

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InterventionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(entity.status);
        }
        // Custom: PUT END
        [HttpPut("{id}/End")]
        public async Task<IActionResult> PutInterventionEnd(long id)
        {
            DateTime localDate = DateTime.Now;
            var entity = _context.interventions.FirstOrDefault(intervention => intervention.Id == id);

            if (entity == null)
            {
                return BadRequest();
            }

            if (entity != null && entity.start_date_and_time_of_the_intervention != null) 
            {
                entity.status = "Completed";
                entity.end_date_and_time_of_the_intervention = localDate;
                _context.SaveChanges();
            }
            // _context.Entry(intervention).State = EntityState.Modified;//

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InterventionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(entity.status);
        }

        [HttpPut("{id}/Reset")]
        public async Task<IActionResult> PutInterventionReset(long id)
        {
            DateTime localDate = DateTime.Now;
            var entity = _context.interventions.FirstOrDefault(intervention => intervention.Id == id);

            if (entity == null)
            {
                return BadRequest();
            }

            if (entity != null) 
            {
                entity.status = "Pending";
                entity.start_date_and_time_of_the_intervention = null;
                entity.end_date_and_time_of_the_intervention = null;
                _context.SaveChanges();
            }
            // _context.Entry(intervention).State = EntityState.Modified;//

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InterventionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(entity.status);
        }

        // POST: api/Intervention
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Intervention>> PostIntervention(Intervention intervention)
        {
          if (_context.interventions == null)
          {
              return Problem("Entity set 'RocketElevatorsContext.interventions'  is null.");
          }
            _context.interventions.Add(intervention);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIntervention", new { id = intervention.Id }, intervention);
        }

        // DELETE: api/Intervention/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIntervention(long id)
        {
            if (_context.interventions == null)
            {
                return NotFound();
            }
            var intervention = await _context.interventions.FindAsync(id);
            if (intervention == null)
            {
                return NotFound();
            }

            _context.interventions.Remove(intervention);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InterventionExists(long id)
        {
            return (_context.interventions?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
