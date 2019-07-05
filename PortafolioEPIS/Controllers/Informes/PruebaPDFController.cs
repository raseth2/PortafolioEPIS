using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using jsreport.MVC;
using jsreport.Types;
using PortafolioEPIS.Models;
using PortafolioEPIS.Filters;

namespace PortafolioEPIS.Controllers.Informes
{
    [Autenticado]
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



















        public ActionResult Index()
        {
            return View();
        }

        
        [EnableJsReport()]
        public ActionResult Invoice()
        {
            HttpContext.JsReportFeature().Recipe(Recipe.ChromePdf);

            return View(InvoiceModel.Example());
        }

        [EnableJsReport()]
        public ActionResult InvoiceDownload()
        {
            HttpContext.JsReportFeature().Recipe(Recipe.ChromePdf)
                .OnAfterRender((r) => HttpContext.Response.Headers["Content-Disposition"] = "attachment; filename=\"myReport.pdf\"");

            return View("Invoice", InvoiceModel.Example());
        }

        [EnableJsReport()]
        public ActionResult InvoiceWithHeader()
        {
            HttpContext.JsReportFeature()
                .Recipe(Recipe.ChromePdf)
                .Configure((r) => r.Template.Chrome = new Chrome
                {
                    HeaderTemplate = this.RenderViewToString("Header", new { }),
                    DisplayHeaderFooter = true,
                    MarginTop = "2cm",
                    MarginLeft = "1cm",
                    MarginBottom = "2cm",
                    FooterTemplate = " "
                });

            return View("Invoice", InvoiceModel.Example());
        }

        [EnableJsReport()]
        public ActionResult Items()
        {
            HttpContext.JsReportFeature()
                .Recipe(Recipe.HtmlToXlsx);

            return View(InvoiceModel.Example());
        }

        [EnableJsReport()]
        public ActionResult ItemsExcelOnline()
        {
            HttpContext.JsReportFeature()
                .Configure(req => req.Options.Preview = true)
                .Recipe(Recipe.HtmlToXlsx);

            return View("Items", InvoiceModel.Example());
        }

        [EnableJsReport()]
        public ActionResult InvoiceDebugLogs()
        {
            HttpContext.JsReportFeature()
                .DebugLogsToResponse()
                .Recipe(Recipe.ChromePdf);

            return View("Invoice", InvoiceModel.Example());
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


    }
}