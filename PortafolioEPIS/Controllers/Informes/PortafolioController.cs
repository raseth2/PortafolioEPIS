using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortafolioEPIS.Filters;

namespace PortafolioEPIS.Controllers.Informes
{
    [Autenticado]
    public class PortafolioController : Controller
    {
        // Accion Listar
        public ActionResult Index()
        {
            return View();
        }

               
        // Accion Agregar
        public ActionResult Agregar()
        {
            return View();
        }
    }
}