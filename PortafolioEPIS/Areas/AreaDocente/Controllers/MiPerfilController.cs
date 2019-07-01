using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortafolioEPIS.Models;

namespace PortafolioEPIS.Areas.AreaDocente.Controllers
{
    public class MiPerfilController : Controller
    {
        //Instanciar la clase 
        private Tbl_Docente objDocente = new Tbl_Docente();
        private Tbl_Profesion objProfesion = new Tbl_Profesion();
        private Tbl_CargoDocente objCargoDocente = new Tbl_CargoDocente();
        private Tbl_DetalleCargaAcademica objDetalleCargaAcademica = new Tbl_DetalleCargaAcademica();
        private Tbl_PruebaEntrada objpruebaentrada = new Tbl_PruebaEntrada();
        private Tbl_Portafolio objportafolio = new Tbl_Portafolio();
        private Tbl_InformeFinal objInformeFinal = new Tbl_InformeFinal();

        // GET: AreaDocente/MiPerfil
        public ActionResult Index()
        {
            return View();
        }

       
    }
}