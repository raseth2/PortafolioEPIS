using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using PortafolioEPIS.Models;

namespace PortafolioEPIS.Areas.Docente.Controllers
{
    public class DetalleCargaAcademicaController : Controller
    {
        private Tbl_DetalleCargaAcademica objDetalleCargaAcademica = new Tbl_DetalleCargaAcademica();
        
        // GET: Docente/DetalleCargaAcademica
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VistaCursosDocente(int id)
        {
            //ViewBag.id = id;
            ViewBag.id = 201900;
            return View(objDetalleCargaAcademica.Listar());
        }
    }
}