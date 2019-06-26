using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortafolioEPIS.Models;
using PortafolioEPIS.Filters;

namespace PortafolioEPIS.Controllers
{
    public class LoginController : Controller
    {
        private Tbl_Usuario usuario = new Tbl_Usuario();
        // GET: Login
        [NoLogin]
        public ActionResult IngresoSistema()
        {
            return View();
        }
        //public JsonResult Validar(string Usuario, string Password)
        //{
        //    var rm = usuario.ValidarLogin(Usuario, Password);
        //    if (rm.response)
        //    {
        //        rm.href = Url.Content("/Home");
        //    }

        //    return Json(rm);
        //}

        
        public ActionResult Validar(string Usuario, string Password,int cargo)
        {
            var rm = usuario.ValidarLogin(Usuario, Password,cargo);
            if (rm.response)
            {
                if(cargo==1)
                {
                    rm.href = Url.Content("~/Inicio");
                }
                if(cargo==2)
                {
                    rm.href = Url.Content("~/Inicio");
                }
                if(cargo==3)
                {
                    rm.href = Url.Content("~/AreaDocente/Miperfil");
                }
                
            }
            else
            {
                rm.href = Url.Content("~/Login/IngresoSistema");
            }

            return Redirect(rm.href);
        }

        public ActionResult Logout()
        {
            SessionHelper.DestroyUserSession();
            return Redirect("~/Login/IngresoSistema");
        }
    }
}