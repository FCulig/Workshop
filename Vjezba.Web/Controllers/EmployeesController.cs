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

namespace Vjezba.Web.Controllers
{
    [Authorize(Roles = "Manager")]
    public class EmployeesController : BaseController
    {
        public EmployeesController(WorkshopDbContext dbContext) : base(dbContext)
        {
        }

        public IActionResult Index()
        {
            var Employees = DbContext.Employees
                .Include(p => p.City)
                .Include(p => p.Breakdowns)
                .ToList();
            return View(Employees);
        }

        public IActionResult AddEmployee()
        {
            FillDropDownValues();
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee e)
        {
            if (ModelState.IsValid)
            {
                DbContext.Employees.Add(e);
                this.DbContext.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return BadRequest();
        }

        [Route("[controller]/{id}/Edit")]
        [ActionName(nameof(Edit))]
        public IActionResult Edit(int id)
        {
            var employee = DbContext.Employees.Where(p => p.ID == id).FirstOrDefault();
            FillDropDownValues();
            return View(employee);
        }

        [HttpPost]
        [Route("[controller]/{id}/Edit")]
        [ActionName(nameof(Edit))]
        public async Task<IActionResult> EditEmployee(int id)
        {
            var employee = DbContext.Employees.FirstOrDefault(c => c.ID == id);
            var ok = await this.TryUpdateModelAsync(employee);

            if (ok && this.ModelState.IsValid)
            {
                DbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            FillDropDownValues();
            return View();
        }

        [Route("[controller]/{id}/Details")]
        public IActionResult Details(int id)
        {
            var employee = DbContext.Employees
                .Where(p => p.ID == id)
                .Include(p => p.City)
                .Include(p => p.Breakdowns)
                .FirstOrDefault();
            return View(employee);
        }

        public IActionResult Delete(int id)
        {
            var employee = DbContext.Employees
                .Where(p => p.ID == id)
                .Include(p => p.Breakdowns)
                .FirstOrDefault();

            if (employee != null)
            {
                if (employee.Breakdowns.Count() > 0)
                {
                    foreach (var item in employee.Breakdowns)
                    {
                        DbContext.Breakdowns.Remove(item);
                    }
                }

                DbContext.Employees.Remove(employee);
                DbContext.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return BadRequest();
        }

        public void FillDropDownValues()
        {
            var selectItems = new List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem>();

            var listItem = new SelectListItem();

            foreach (var city in DbContext.Cities)
            {
                listItem = new SelectListItem();
                listItem.Text = city.Name;
                listItem.Value = city.ID.ToString();
                selectItems.Add(listItem);
            }

            ViewBag.Cities = selectItems;
        }
    }
}