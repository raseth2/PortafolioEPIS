using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortafolioEPIS.Areas.AreaDocente.Controllers
{
    public class DashboardController : Controller
    {
        // GET: AreaDocente/Dashboard
        public ActionResult Index()
        {
            return View();
        }
    }
}