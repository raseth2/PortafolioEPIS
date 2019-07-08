using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using PortafolioEPIS.Models;
using PortafolioEPIS.Filters;

using System.Web.UI.WebControls;
using System.Web.UI;
using System.IO;

namespace PortafolioEPIS.Controllers
{
    [Autenticado]
    public class UsuarioController : Controller
    {
        Tbl_Usuario objUsuario = new Tbl_Usuario();
        Tbl_Docente objDocente = new Tbl_Docente();

        public ActionResult Index()
        {

            return View(objUsuario.Listar());
        }

        //Accion Visualizar

        public ActionResult Ver(int id)
        {
            return View(objUsuario.Obtener(id));
        }

        public ActionResult Seleccionar()
        {
            return View(objDocente.Listar());
        }
        // Accion Agregar
        public ActionResult Agregar(int id = 0, int nuevo=0)
        {
            ViewBag.Tbl_Docente = objDocente.Listar();
            ViewBag.IdNuevo = nuevo;

            return View(id == 0 ? new Tbl_Usuario()//Agregar un nuevo objeto
               : objUsuario.Obtener(id));
        }

        //Action Guardar
        public ActionResult Guardar(Tbl_Usuario objUsuario, string pass)
        {
            if (ModelState.IsValid)
            {
                if (objUsuario.Codigo_Usuario==0)
                {
                    objUsuario.FechaCreacion_Usuario = DateTime.Now;
                    objUsuario.FechaActualizacion_Usuario = DateTime.Now;
                    objUsuario.Password_Usuario = HashHelper.SHA1(pass);
                    objUsuario.Guardar();
                    return Redirect("~/Usuario");
                }
                else
                {
                    objUsuario.FechaCreacion_Usuario = DateTime.Now;
                    objUsuario.FechaActualizacion_Usuario = DateTime.Now;
                    objUsuario.Guardar();
                    return Redirect("~/Usuario");
                }
                
            }
            else
            {
                return View("~/Views/Usuario/Agregar.cshtml");
            }

        }

        //Action Eliminar

        public ActionResult Eliminar(int id)
        {
            objUsuario.Codigo_Usuario = id;
            objUsuario.Eliminar();
            return Redirect("~/Usuario");
        }

        public ActionResult ExportaExcel()
        {
            var gv = new GridView();
            gv.DataSource = objUsuario.Listar();
            gv.DataBind();

            Response.ClearContent();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment; filename=RegistroUsuario.xls");
            Response.ContentType = "application/ms-excel";

            Response.Charset = "";
            StringWriter objStringWriter = new StringWriter();
            HtmlTextWriter objHtmlTextWriter = new HtmlTextWriter(objStringWriter);

            gv.RenderControl(objHtmlTextWriter);

            Response.Output.Write(objStringWriter.ToString());
            Response.Flush();
            Response.End();

            return View("~/Usuario");

        }
    }
}