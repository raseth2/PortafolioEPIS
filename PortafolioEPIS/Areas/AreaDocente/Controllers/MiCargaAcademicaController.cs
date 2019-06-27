using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortafolioEPIS.Models;

namespace PortafolioEPIS.Areas.AreaDocente.Controllers
{
    public class MiCargaAcademicaController : Controller
    {
        // GET: AreaDocente/MiCargaAcademica
        private Tbl_Docente objDocente = new Tbl_Docente();
        private Tbl_Profesion objProfesion = new Tbl_Profesion();
        private Tbl_CargoDocente objCargoDocente = new Tbl_CargoDocente();
        private Tbl_DetalleCargaAcademica objDetalleCargaAcademica = new Tbl_DetalleCargaAcademica();
        private Tbl_PruebaEntrada objpruebaentrada = new Tbl_PruebaEntrada();
        private Tbl_Portafolio objportafolio = new Tbl_Portafolio();
        private Tbl_InformeFinal objInformeFinal = new Tbl_InformeFinal();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VerDocente(int id = 0)
        {
            return View(objDocente.Obtener(id));
        }

        public ActionResult VerCursosDocente(int id)
        {
            ViewBag.id = id;
            return View(objDetalleCargaAcademica.Listar());
        }

        public ActionResult VistaPruebaEntrada(int id)
        {
            ViewBag.id = id;
            ViewBag.prueba = objpruebaentrada.Listar();
            return View(objDetalleCargaAcademica.Listar());
        }

        public ActionResult VistaPortafolioU(int id)
        {
            ViewBag.id = id;
            ViewBag.prueba = objportafolio.Listar();
            return View(objDetalleCargaAcademica.Listar());
        }

        public ActionResult VistaInformeFinal(int id)
        {
            ViewBag.id = id;
            ViewBag.prueba = objInformeFinal.Listar();
            return View(objDetalleCargaAcademica.Listar());
        }

    }
}