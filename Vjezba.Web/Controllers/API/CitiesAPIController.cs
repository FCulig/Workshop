using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vjezba.DAL;
using Vjezba.Model;

namespace Vjezba.Web.Controllers.API
{
    [Route("api/City")]
    [ApiController]
    public class CitiesAPIController : BaseController
    {
        public CitiesAPIController(WorkshopDbContext context) : base(context)
        {
        }

        [HttpGet]
        public IEnumerable<City> GetCities()
        {
            return DbContext.Cities.ToList();
        }

        [HttpGet("{id}")]
        public IActionResult GetCity([FromRoute] int id)
        {
            var city = DbContext.Cities.Where(p => p.ID == id).FirstOrDefault();

            if (city == null)
            {
                return NotFound();
            }

            return Ok(city);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCity([FromRoute] int id, [FromBody] City city)
        {
            city.ID = id;

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DbContext.Entry(city).State = EntityState.Modified;

            try
            {
                await DbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CityExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok();
        }

        [HttpPost]
        public IActionResult PostCity([FromBody] City city)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DbContext.Cities.Add(city);
            DbContext.SaveChangesAsync();

            return CreatedAtAction("GetCity", new { id = city.ID }, city);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCity([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var city = DbContext.Cities.Where(p => p.ID == id).FirstOrDefault();
            if (city == null)
            {
                return NotFound();
            }

            DbContext.Cities.Remove(city);
            DbContext.SaveChanges();

            return Ok(city);
        }

        private bool CityExists(int id)
        {
            return DbContext.Cities.Any(e => e.ID == id);
        }
    }
}