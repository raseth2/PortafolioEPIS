using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortafolioEPIS.Models;
using PortafolioEPIS.Filters;

namespace PortafolioEPIS.Areas.AreaDocente.Controllers
{
    public class LoginDocentesController : Controller
    {
        // GET: AreaDocente/LoginDocentes
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Logout()
        {
            SessionHelper.DestroyUserSession();
            return Redirect("~/Login/IngresoSistema");
        }
    }
}