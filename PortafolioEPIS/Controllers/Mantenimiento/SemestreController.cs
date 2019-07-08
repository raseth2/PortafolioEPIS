using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortafolioEPIS.Models;
using PortafolioEPIS.Filters;

using System.Web.UI.WebControls;
using System.IO;
using System.Web.UI;

namespace PortafolioEPIS.Controllers.Mantenimiento
{
    [Autenticado]
    public class SemestreController : Controller
    {
        //Listar
        //Instanciar la clase Semestre
        private Tbl_Semestre objSemestre = new Tbl_Semestre();

        public ActionResult Index()
        {
            
            return View(objSemestre.Listar());
        }

        //Acction Visualizar

        public ActionResult Visualizar(int id)
        {
            return View(objSemestre.Obtener(id));
        }

        // Accion Agregar
        public ActionResult Agregar(int id = 0)
        {
            ViewBag.semestre = objSemestre.Listar();
            return View(id == 0 ? new Tbl_Semestre()//Agregar un nuevo objeto
               : objSemestre.Obtener(id));
        }
       
        //Action Guardar
        public ActionResult Guardar(Tbl_Semestre objSemestre)
        {
            if (ModelState.IsValid)
            {
                objSemestre.Guardar();
                return Redirect("~/Semestre");
            }
            else
            {
                return View("~/Views/Semestre/Agregar");
            }

        }

        //Action Eliminar

        public ActionResult Eliminar(int id)
        {
            objSemestre.Codigo_Semestre = id;
            objSemestre.Eliminar();
            return Redirect("~/Semestre");
        }

        public ActionResult ExportaExcel()
        {
            var gv = new GridView();
            gv.DataSource = objSemestre.Listar();
            gv.DataBind();

            Response.ClearContent();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment; filename=RegistroSemestre.xls");
            Response.ContentType = "application/ms-excel";

            Response.Charset = "";
            StringWriter objStringWriter = new StringWriter();
            HtmlTextWriter objHtmlTextWriter = new HtmlTextWriter(objStringWriter);

            gv.RenderControl(objHtmlTextWriter);

            Response.Output.Write(objStringWriter.ToString());
            Response.Flush();
            Response.End();

            return View("~/Semestre");

        }
    }
}