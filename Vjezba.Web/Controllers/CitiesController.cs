using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Radionica.Model;
using Vjezba.DAL;
using Vjezba.Model;

namespace Vjezba.Web.Controllers
{
    [Authorize(Roles = "Manager")]
    public class CitiesController : BaseController
    {
        public CitiesController(WorkshopDbContext dbContext) : base(dbContext)
        {
        }

        [HttpPost]
        public IActionResult NewCity(City c)
        {
            if (ModelState.IsValid)
            {
                DbContext.Cities.Add(c);
                this.DbContext.SaveChanges();

                return RedirectToAction("AddEmployee", "Employees");
            }

            return BadRequest();
        }
    }
}