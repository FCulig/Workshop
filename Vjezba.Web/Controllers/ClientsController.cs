using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Radionica.Model;
using Vjezba.DAL;

namespace Vjezba.Web.Controllers
{
    [Authorize]
    public class ClientsController : BaseController
    {
        public ClientsController(WorkshopDbContext dbContext) : base(dbContext)
        {
        }

        public IActionResult Index()
        {
            var clients = DbContext.Clients
                .Include(p => p.Breakdowns)
                .ToList();
            return View(clients);
        }

        [HttpPost]
        public IActionResult AddClient(Client c)
        {
            if (ModelState.IsValid)
            {
                DbContext.Clients.Add(c);
                this.DbContext.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return BadRequest();
        }

        [Route("[controller]/{id}/Details")]
        [ActionName(nameof(Details))]
        public IActionResult Details(int id)
        {
            var client = DbContext.Clients
                .Where(p => p.ID == id)
                .FirstOrDefault();
            return View(client);
        }

        [HttpPost]
        [Route("[controller]/{id}/Edit")]
        [ActionName(nameof(Edit))]
        public async Task<IActionResult> Edit(int id)
        {
            var client = DbContext.Clients.FirstOrDefault(c => c.ID == id);
            var ok = await this.TryUpdateModelAsync(client);

            if (ok && this.ModelState.IsValid)
            {
                DbContext.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var client = DbContext.Clients
                .Where(p => p.ID == id)
                .Include(p => p.Breakdowns)
                .FirstOrDefault();

            if (client != null)
            {
                if(client.Breakdowns.Count() > 0)
                {
                    foreach (var item in client.Breakdowns)
                    {
                        DbContext.Breakdowns.Remove(item);
                    }
                }

                DbContext.Clients.Remove(client);
                DbContext.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return BadRequest();
        }
    }
}