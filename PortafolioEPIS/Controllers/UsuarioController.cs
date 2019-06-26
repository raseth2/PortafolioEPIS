using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using PortafolioEPIS.Models;

namespace PortafolioEPIS.Controllers
{
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

        // Accion Agregar
        public ActionResult Agregar(int id = 0)
        {
            ViewBag.Tbl_Docente = objDocente.Listar();

            return View(id == 0 ? new Tbl_Usuario()//Agregar un nuevo objeto
               : objUsuario.Obtener(id));
        }

        //Action Guardar
        public ActionResult Guardar(Tbl_Usuario objUsuario)
        {
            if (ModelState.IsValid)
            {
                if (objUsuario.Codigo_Usuario==0)
                {
                    objUsuario.FechaCreacion_Usuario = DateTime.Now;
                    objUsuario.FechaActualizacion_Usuario = DateTime.Now;
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
    }
}