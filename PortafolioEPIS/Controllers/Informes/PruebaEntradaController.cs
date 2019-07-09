using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using jsreport.MVC;
using jsreport.Types;
using PortafolioEPIS.Models;
using Rotativa;
using PortafolioEPIS.Filters;

namespace PortafolioEPIS.Controllers.Informes
{
    //[Autenticado]

    public class PruebaEntradaController : Controller
    {
        private Tbl_ConocimientoHabilidad ObjConocimientoHabilidad = new Tbl_ConocimientoHabilidad();
        private Tbl_MedidasCorrectivas ObjMedidadasCorrectivas = new Tbl_MedidasCorrectivas();
        private Tbl_DetalleCargaAcademica objDetalleCargaAcademica = new Tbl_DetalleCargaAcademica();
        private Tbl_PruebaEntrada objPruebaEntrada = new Tbl_PruebaEntrada();
        private Tbl_PlanEstudio objPlanEstudio = new Tbl_PlanEstudio();
        private Tbl_Docente objDocente = new Tbl_Docente();
        private Tbl_Seccion objSeccion = new Tbl_Seccion();
        private Tbl_DetallePlanEstudio objDetallePlanEstudio = new Tbl_DetallePlanEstudio();
        private Tbl_Semestre objSemestre = new Tbl_Semestre();
        private Tbl_CargaAcademica objCargaAcademica = new Tbl_CargaAcademica();
        private Tbl_Portafolio objPortafolio = new Tbl_Portafolio();
        // Accion Listar
        public ActionResult Index()
        {

            return View(objPruebaEntrada.Listar());
        }

        public ActionResult PruebaJsreport()
        {

            return View(objPruebaEntrada.Listar());
        }

        public ActionResult Ver(int id)
        {
            return View(objPruebaEntrada.Obtener(id));
        }
        public ActionResult IndexAdmin()
        {
            return View(objCargaAcademica.Listar());
        }


        public ActionResult IndexLista(int id=0)
        {
            ViewBag.id = id;
            ViewBag.Tbl_CargaAcademica_id = objCargaAcademica.Obtener(id);
            ViewBag.prueba = objPruebaEntrada.Listar();
            ViewBag.carga=objCargaAcademica.Listar();
            return View(objDetalleCargaAcademica.Listar2(id));
        }

        //Action Guardar
        public ActionResult Guardar(Tbl_PruebaEntrada objPruebaEntrada, int evaluados, int codigo, string estado, int idprueba)
        {
            
                objPruebaEntrada.Codigo_PruebaEntrada = idprueba;
                objPruebaEntrada.Codigo_DetalleCargaAcademica = codigo;
                objPruebaEntrada.Evaluados_PruebaEntrada = evaluados;
                objPruebaEntrada.Fecha_PruebaEntrada = DateTime.Now;
                objPruebaEntrada.Estado_PruebaEntrada = estado;
                objPruebaEntrada.Guardar();
                return Redirect("~/PruebaEntrada/Agregar/" + codigo);
          
            //}
            //else
            //{
            //    return View("~/Views/PruebaEntrada/Agregar.cshtml");
            //}

        }

        public ActionResult GuardarEstado(Tbl_PruebaEntrada objPruebaEntrada, int id=0,int codigodetalle=0,int evaluados=0,string estado=null,int iddocente=0)
        {

           
                
            objPruebaEntrada.Estado_PruebaEntrada = estado;
           
           

            objPruebaEntrada.Codigo_PruebaEntrada = id;
            objPruebaEntrada.Codigo_DetalleCargaAcademica = codigodetalle;
            objPruebaEntrada.Evaluados_PruebaEntrada = evaluados;
            objPruebaEntrada.Fecha_PruebaEntrada = DateTime.Now;
            objPruebaEntrada.Guardar();

            return Redirect("~/Docente/Ver/" + iddocente);

        }

    


        //Action Eliminar

        public ActionResult Eliminar(int id)
        {
            objPruebaEntrada.Codigo_PruebaEntrada = id;
            objPruebaEntrada.Eliminar();
            return Redirect("~/CargaAcademica");
        }
        //public ActionResult Agregar(int id = 0)
        //{
        //    ViewBag.Tbl_Semestre = objSemestre.Listar();

        //    return View(id == 0 ? new Tbl_PruebaEntrada()//Agregar un nuevo objeto
        //       : objPruebaEntrada.Obtener(id));
        //}
        // Accion Agregar
        public ActionResult Agregar(int id)
        {
            ViewBag.prueba = objPruebaEntrada.Listar();
            return View(objDetalleCargaAcademica.Obtener(id));
        }

        
        public ActionResult PrintFilter(string tipo)
        {
            List<Tbl_DetalleCargaAcademica> listacarga = objDetalleCargaAcademica.Listar();

            foreach (var l in listacarga)
            {
               
                Print(l.Codigo_DetalleCargaAcademica, l.Tbl_DetallePlanEstudio.Asignatura_DetallePlanEstudio);
               

            }
            //ActionAsPdf dowload = new ActionAsPdf();

            return Redirect("~/PruebaEntrada/IndexLista/8");
        }
        //parte guimer PDF
        public ActionResult Print(int id, string nombreCurso)
        {
            return new ActionAsPdf("ListaPDFPruebaEntrada/" + id) { FileName = nombreCurso+".pdf" };
        }

        // Metodo para Imprimir PDF Docente
        public ActionResult ListaPDFPruebaEntrada(int id)
        {
            ViewBag.prueba = objPruebaEntrada.Listar();
            ViewBag.conocimientoHabilidad = ObjConocimientoHabilidad.Listar();
            ViewBag.ListaTbl_MedidasCorrectivas = ObjMedidadasCorrectivas.Listar();
            return View(objDetalleCargaAcademica.Obtener(id));
        }
        public ActionResult ExportaAPDF(int id)
        {
            return new ActionAsPdf("ListaPDFPruebaEntrada/" + id);
        }

        public ActionResult ListaPDFPruebaEntrada20(int id)
        {
            ViewBag.prueba = objPruebaEntrada.Listar();
            ViewBag.conocimientoHabilidad = ObjConocimientoHabilidad.Listar();
            ViewBag.ListaTbl_MedidasCorrectivas = ObjMedidadasCorrectivas.Listar();
            return View(objDetalleCargaAcademica.Obtener(id));
        }
        public ActionResult ExportaAPDF2(int id)
        {
            return new ActionAsPdf("ListaPDFPruebaEntrada2/" + id);
        }


        //iReport
        [EnableJsReport()]
        public ActionResult ListaPDFPruebaEntrada2(int id)
        {
            ViewBag.prueba = objPruebaEntrada.Listar();
            ViewBag.conocimientoHabilidad = ObjConocimientoHabilidad.Listar();
            ViewBag.ListaTbl_MedidasCorrectivas = ObjMedidadasCorrectivas.Listar();


            HttpContext.JsReportFeature().Recipe(Recipe.ChromePdf);
            return View(objDetalleCargaAcademica.Obtener(id));
            //return View(InvoiceModel.Example());
        }


    }
}