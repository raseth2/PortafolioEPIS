using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortafolioEPIS.Models;
using System.IO;
using Rotativa;
using PortafolioEPIS.Filters;

namespace PortafolioEPIS.Controllers.Informes
{
    //[Autenticado]
    public class PortafolioU2Controller : Controller
    {
        private Tbl_DetalleCargaAcademica objDetalleCargaAcademica = new Tbl_DetalleCargaAcademica();
        private Tbl_Portafolio objPortafolio = new Tbl_Portafolio();
        private Tbl_CargaAcademica objCargaAcademica = new Tbl_CargaAcademica();
        private Tbl_Material objMaterial = new Tbl_Material();
        private Tbl_PruebaEntrada objPruebaEntrada = new Tbl_PruebaEntrada();
        // Accion Listar
        public ActionResult Index()
        {
            return View();
        }
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
            return View(objDetalleCargaAcademica.Listar2(id));
        }

        // Accion Agregar
        public ActionResult Agregar(int id)
        {
            ViewBag.prueba = objPortafolio.Listar();
            List<Tbl_Portafolio> listPortafolio = objPortafolio.Listar();
            int foerach = 0;


            foreach (var listaportafolio in listPortafolio)
            {
                if (listaportafolio.Codigo_DetalleCargaAcademica == id)
                {
                    ViewBag.ListarEvidencia = objMaterial.Listar(listaportafolio.Codigo_Portafolio); //obtener la lista deevidencias de un  portafolio
                    foerach++;
                }

            }

            if (foerach == 0)
            {
                ViewBag.ListarEvidencia = objMaterial.Listar(0); //obtener la lista deevidencias de un  portafolio
            }


            // ViewBag.ObtenerEvidencia = objMaterial.ObtenerEvidencia(id);//esto es en el caso de s¿que se agregue modificar
            return View(objDetalleCargaAcademica.Obtener(id));
        }

        [HttpPost]
        public ActionResult Evidencia(Tbl_Material objEvidencia, HttpPostedFileBase archivo, int Codigo_detalle_carga)
        {
            if (archivo != null)
            {

                archivo.SaveAs(Server.MapPath("~/Imagen/" + archivo.FileName));
                objEvidencia.Archivo_Material1 = archivo.FileName;
                objEvidencia.TipoArchivo_Material1 = Path.GetExtension(archivo.FileName);
                objEvidencia.PesoArchivo_Material1 = Convert.ToString(Math.Round((Convert.ToDecimal(archivo.ContentLength) / (1024 * 1024)), 2)) + " Mb";
            }

            objEvidencia.Guardar();
            return Redirect("~/PortafolioU2/Agregar/" + Codigo_detalle_carga);
        }

        [HttpPost]
        public ActionResult Evidencia1(Tbl_Material objEvidencia, HttpPostedFileBase archivo1, int Codigo_detalle_carga)
        {
            if (archivo1 != null)
            {

                archivo1.SaveAs(Server.MapPath("~/Imagen/" + archivo1.FileName));
                objEvidencia.Archivo_Material1 = archivo1.FileName;
                objEvidencia.TipoArchivo_Material1 = Path.GetExtension(archivo1.FileName);
                objEvidencia.PesoArchivo_Material1 = Convert.ToString(Math.Round((Convert.ToDecimal(archivo1.ContentLength) / (1024 * 1024)), 2)) + " Mb";
            }

            objEvidencia.Guardar();
            return Redirect("~/PortafolioU2/Agregar/" + Codigo_detalle_carga);
        }

        public ActionResult Guardar(Tbl_Portafolio objPortafolioU1, int idprueba, int retirados, int abandonos, int aprobados, int codigo, string estado, string unidad)
        {
            if (aprobados > 0)
            {
                objPortafolioU1.Codigo_Portafolio = idprueba;
                objPortafolioU1.Codigo_DetalleCargaAcademica = codigo;
                objPortafolioU1.Retirados_Portafolio = retirados;
                objPortafolioU1.Abandono_Portafolio = abandonos;
                objPortafolioU1.Aprobados_Portafolio = aprobados;
                objPortafolioU1.Unidad_Portafolio = unidad;
                objPortafolioU1.Fecha_Portafolio = DateTime.Now;
                objPortafolioU1.Estado_Portafolio = estado;
                objPortafolioU1.Guardar();
            }
           
            return Redirect("~/PortafolioU2/Agregar/" + codigo);

            //}
            //else
            //{
            //    return View("~/Views/PruebaEntrada/Agregar.cshtml");
            //}



        }

        public ActionResult GuardarEstado(Tbl_Portafolio objPortafolio, int id = 0, int codigodetalle = 0, string unidad = null, int retirados = 0, int abandono = 0, int aprobados = 0, string estado = null, int iddocente = 0)
        {



            objPortafolio.Estado_Portafolio = estado;

            objPortafolio.Codigo_Portafolio = id;
            objPortafolio.Codigo_DetalleCargaAcademica = codigodetalle;
            objPortafolio.Unidad_Portafolio = unidad;
            objPortafolio.Retirados_Portafolio = retirados;
            objPortafolio.Abandono_Portafolio = abandono;
            objPortafolio.Aprobados_Portafolio = aprobados;
            objPortafolio.Fecha_Portafolio = DateTime.Now;
            objPortafolio.Guardar();

            return Redirect("~/Docente/Ver/" + iddocente);

        }

        public ActionResult ListaPDFPortafolioU2(int id)
        {
            ViewBag.prueba = objPruebaEntrada.Listar();
            ViewBag.Portafolio = objPortafolio.Listar();

            int foerach = 0;
            List<Tbl_Portafolio> listPortafolio = objPortafolio.Listar();

            foreach (var listaportafolio in listPortafolio)
            {
                if (listaportafolio.Codigo_DetalleCargaAcademica == id)
                {
                    ViewBag.ListarEvidencia = objMaterial.Listar(listaportafolio.Codigo_Portafolio); //obtener la lista deevidencias de un  portafolio
                    foerach++;
                }

            }

            if (foerach == 0)
            {
                ViewBag.ListarEvidencia = objMaterial.Listar(0); //obtener la lista deevidencias de un  portafolio
            }

            //ViewBag.prueba = objPruebaEntrada.Listar();
            //ViewBag.conocimientoHabilidad = ObjConocimientoHabilidad.Listar();
            //ViewBag.ListaTbl_MedidasCorrectivas = ObjMedidadasCorrectivas.Listar();
            return View(objDetalleCargaAcademica.Obtener(id));
        }
        public ActionResult Print(int id, string nombreCurso)
        {
            return new ActionAsPdf("ListaPDFPortafolioU2/" + id) { FileName = nombreCurso + "_PortafolioU2.pdf" };
        }
        public ActionResult ExportaAPDF(int id)
        {
            return new ActionAsPdf("ListaPDFPortafolioU2/" + id);
        }
    }
}