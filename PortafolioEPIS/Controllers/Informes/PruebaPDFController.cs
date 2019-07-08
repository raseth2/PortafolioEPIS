using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using jsreport.MVC;
using jsreport.Types;
using PortafolioEPIS.Models;
using PortafolioEPIS.Filters;
using Rotativa;

namespace PortafolioEPIS.Controllers.Informes
{
    //[Autenticado]
    public class PruebaPDFController : Controller
    {
        private Tbl_DetalleCargaAcademica objDetalleCargaAcademica = new Tbl_DetalleCargaAcademica();
        private Tbl_Docente objDocente = new Tbl_Docente();

        Tbl_Docente objdocente = new Tbl_Docente();



        private Tbl_ConocimientoHabilidad ObjConocimientoHabilidad = new Tbl_ConocimientoHabilidad();
        private Tbl_MedidasCorrectivas ObjMedidadasCorrectivas = new Tbl_MedidasCorrectivas();
        
        private Tbl_PruebaEntrada objPruebaEntrada = new Tbl_PruebaEntrada();
        private Tbl_PlanEstudio objPlanEstudio = new Tbl_PlanEstudio();
        
        private Tbl_Seccion objSeccion = new Tbl_Seccion();
        private Tbl_DetallePlanEstudio objDetallePlanEstudio = new Tbl_DetallePlanEstudio();
        private Tbl_Semestre objSemestre = new Tbl_Semestre();
        private Tbl_CargaAcademica objCargaAcademica = new Tbl_CargaAcademica();
        private Tbl_Portafolio objPortafolio = new Tbl_Portafolio();

        public ActionResult IndexAdmin()
        {
            return View(objCargaAcademica.Listar());
        }

        public ActionResult IndexLista(int id = 0)
        {
            ViewBag.id = id;
            ViewBag.Tbl_CargaAcademica_id = objCargaAcademica.Obtener(id);
            ViewBag.portafolio1 = objPortafolio.Listar();
            ViewBag.carga = objCargaAcademica.Listar();
            ViewBag.listaDocente = objDocente.Listar();
            return View(objDetalleCargaAcademica.Listar2(id));
        }


        public ActionResult Index()
        {
            return View();
        }

        

        public ActionResult Reporte()
        {
            ViewBag.listaDocente = objDocente.Listar();
            return View(objDetalleCargaAcademica.Listar());
        }



        //iReport
        [EnableJsReport()]
        public ActionResult ListaPDFPruebaEntrada2()
        {
            HttpContext.JsReportFeature().Recipe(Recipe.ChromePdf);

            return View(InvoiceModel.Example());
        }

        // Metodo para Imprimir PDF Carga Academica de Docentes y Cursos

        public ActionResult ListaPDFDocenteCursos(int id = 0)
        {
            ViewBag.id = id;
            ViewBag.Tbl_CargaAcademica_id = objCargaAcademica.Obtener(id);
            ViewBag.portafolio1 = objPortafolio.Listar();
            ViewBag.carga = objCargaAcademica.Listar();
            ViewBag.listaDocente = objDocente.Listar();
            return View(objDetalleCargaAcademica.Listar2(id));
        }
        
        public ActionResult ExportaAPDFDocenteCursos(int id)
        {
            return new ActionAsPdf("ListaPDFDocenteCursos/"+id);
        }
    }
}