using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vjezba.DAL;

namespace Vjezba.Web.Controllers
{
    public class BaseController : Controller
    {
        public WorkshopDbContext DbContext { get; private set; }

        public BaseController(WorkshopDbContext dbContext)
        {
            this.DbContext = dbContext;
        }
    }
}