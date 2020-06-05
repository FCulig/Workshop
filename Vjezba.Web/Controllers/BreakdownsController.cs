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
using Vjezba.Web.Models;

namespace Vjezba.Web.Controllers
{
    public class BreakdownsController : BaseController
    {
        public BreakdownsController(WorkshopDbContext dbContext) : base(dbContext)
        {
        }

        public IActionResult Index()
        {
            var breakdowns = DbContext.Breakdowns
                .Include(p => p.Employee)
                .Include(p => p.Client)
                .ToList();
            return View(breakdowns);
        }

        [HttpPost]
        public IActionResult FilterBreakdowns(FilterBreakdownsModel model)
        {
            var breakdowns = DbContext.Breakdowns
                .Include(p => p.Client)
                .Include(p => p.Employee)
                .ToList();

            if (model.Name != null)
            {
                breakdowns = breakdowns.Where(p => p.Name.ToLower().Contains(model.Name.ToLower())).ToList();
            }

            return PartialView("_BreakdownsTable", breakdowns);
        }

        [Authorize]
        public IActionResult NewBreakdown()
        {
            FillDropDownClientsValues();
            FillDropDownEmployeesValues();
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult NewBreakdown(Breakdown b)
        {
            if (ModelState.IsValid)
            {
                DbContext.Breakdowns.Add(b);
                this.DbContext.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return BadRequest();
        }

        public IActionResult Details(int id)
        {
            var breakdown = DbContext.Breakdowns
                .Where(p => p.ID == id)
                .Include(p => p.Client)
                .Include(p => p.Employee)
                .FirstOrDefault();
            FillDropDownClientsValues();
            FillDropDownEmployeesValues();
            return View(breakdown);
        }

        [Authorize]
        [HttpPost]
        [Route("[controller]/{id}/Edit")]
        [ActionName(nameof(Edit))]
        public async Task<IActionResult> Edit(int id)
        {
            var breakdown = DbContext.Breakdowns.FirstOrDefault(c => c.ID == id);
            var ok = await this.TryUpdateModelAsync(breakdown);

            if (ok && this.ModelState.IsValid)
            {
                DbContext.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult ClientsBreakdowns(int id)
        {
            var breakdowns = DbContext.Breakdowns
                .Where(p => p.ClientID == id)
                .ToList();
            return PartialView("_ClientsBreakdowns", breakdowns);
        }

        [Authorize]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var breakdown = DbContext.Breakdowns
                .Where(p => p.ID == id)
                .FirstOrDefault();

            if (breakdown != null)
            {
                DbContext.Breakdowns.Remove(breakdown);
                DbContext.SaveChanges();

                var breakdowns = DbContext.Breakdowns
                    .Where(p => p.ClientID == breakdown.ClientID)
                    .ToList();
                return PartialView("_ClientsBreakdowns", breakdowns);
            }

            return BadRequest();
        }

        public void FillDropDownClientsValues()
        {
            var selectItems = new List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem>();

            var listItem = new SelectListItem();

            foreach (var client in DbContext.Clients)
            {
                listItem = new SelectListItem();
                listItem.Text = client.FirstName + ' ' + client.LastName;
                listItem.Value = client.ID.ToString();
                selectItems.Add(listItem);
            }

            ViewBag.Clients = selectItems;
        }

        public void FillDropDownEmployeesValues()
        {
            var selectItems = new List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem>();

            var listItem = new SelectListItem();
            foreach (var employee in DbContext.Employees)
            {
                listItem = new SelectListItem();
                listItem.Text = employee.FirstName + ' ' + employee.LastName;
                listItem.Value = employee.ID.ToString();
                selectItems.Add(listItem);
            }

            ViewBag.Employees = selectItems;
        }
    }
}