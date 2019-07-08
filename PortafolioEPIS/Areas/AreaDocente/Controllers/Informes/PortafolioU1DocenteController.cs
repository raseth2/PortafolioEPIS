using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortafolioEPIS.Models;
using System.IO;
using Rotativa;
using PortafolioEPIS.Filters;

namespace PortafolioEPIS.Areas.AreaDocente.Controllers.Informes
{
    [Autenticado]
    public class PortafolioU1DocenteController : Controller
    {
        private Tbl_DetalleCargaAcademica objDetalleCargaAcademica = new Tbl_DetalleCargaAcademica();
        private Tbl_Portafolio objPortafolio = new Tbl_Portafolio();
        private Tbl_Material objMaterial = new Tbl_Material();

        // Accion Listar
        public ActionResult Index()
        {
            return View();
        }


        // Accion Agregar
        public ActionResult Agregar(int id)
        {
            ViewBag.prueba = objPortafolio.Listar();
            ViewBag.material = objMaterial.Listar1();
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
        public ActionResult Evidencia(Tbl_Material objEvidencia, HttpPostedFileBase archivo, HttpPostedFileBase archivo1, HttpPostedFileBase archivo3, HttpPostedFileBase archivo4, HttpPostedFileBase archivo5, HttpPostedFileBase archivo6, HttpPostedFileBase archivo7, HttpPostedFileBase archivo8, HttpPostedFileBase archivo9, HttpPostedFileBase archivo10, int Codigo_detalle_carga)
        {
            if (archivo != null)
            {

                archivo.SaveAs(Server.MapPath("~/Imagen/" + archivo.FileName));
                objEvidencia.Archivo_Material1 = archivo.FileName;
                objEvidencia.TipoArchivo_Material1 = Path.GetExtension(archivo.FileName);
                objEvidencia.PesoArchivo_Material1 = Convert.ToString(Math.Round((Convert.ToDecimal(archivo.ContentLength) / (1024 * 1024)), 2)) + " Mb";
            }
            if (archivo1 != null)
            {

                archivo1.SaveAs(Server.MapPath("~/Imagen/" + archivo1.FileName));
                objEvidencia.Archivo_Material2 = archivo1.FileName;
                objEvidencia.TipoArchivo_Material2 = Path.GetExtension(archivo1.FileName);
                objEvidencia.PesoArchivo_Material2 = Convert.ToString(Math.Round((Convert.ToDecimal(archivo1.ContentLength) / (1024 * 1024)), 2)) + " Mb";
            }
            if (archivo3 != null)
            {

                archivo3.SaveAs(Server.MapPath("~/Imagen/" + archivo3.FileName));
                objEvidencia.Archivo_Material3 = archivo3.FileName;
                objEvidencia.TipoArchivo_Material3 = Path.GetExtension(archivo3.FileName);
                objEvidencia.PesoArchivo_Material3 = Convert.ToString(Math.Round((Convert.ToDecimal(archivo3.ContentLength) / (1024 * 1024)), 2)) + " Mb";
            }

            if (archivo4 != null)
            {

                archivo4.SaveAs(Server.MapPath("~/Imagen/" + archivo4.FileName));
                objEvidencia.Archivo_Material4 = archivo4.FileName;
                objEvidencia.TipoArchivo_Material4 = Path.GetExtension(archivo4.FileName);
                objEvidencia.PesoArchivo_Material4 = Convert.ToString(Math.Round((Convert.ToDecimal(archivo4.ContentLength) / (1024 * 1024)), 2)) + " Mb";
            }

            if (archivo5 != null)
            {

                archivo5.SaveAs(Server.MapPath("~/Imagen/" + archivo5.FileName));
                objEvidencia.Archivo_Material5 = archivo5.FileName;
                objEvidencia.TipoArchivo_Material5 = Path.GetExtension(archivo5.FileName);
                objEvidencia.PesoArchivo_Material5 = Convert.ToString(Math.Round((Convert.ToDecimal(archivo5.ContentLength) / (1024 * 1024)), 2)) + " Mb";
            }

            if (archivo6 != null)
            {

                archivo6.SaveAs(Server.MapPath("~/Imagen/" + archivo6.FileName));
                objEvidencia.Archivo_Material6 = archivo6.FileName;
                objEvidencia.TipoArchivo_Material6 = Path.GetExtension(archivo6.FileName);
                objEvidencia.PesoArchivo_Material6 = Convert.ToString(Math.Round((Convert.ToDecimal(archivo6.ContentLength) / (1024 * 1024)), 2)) + " Mb";
            }

            if (archivo7 != null)
            {

                archivo7.SaveAs(Server.MapPath("~/Imagen/" + archivo7.FileName));
                objEvidencia.Archivo_Material7 = archivo7.FileName;
                objEvidencia.TipoArchivo_Material7 = Path.GetExtension(archivo7.FileName);
                objEvidencia.PesoArchivo_Material7 = Convert.ToString(Math.Round((Convert.ToDecimal(archivo7.ContentLength) / (1024 * 1024)), 2)) + " Mb";
            }

            if (archivo8 != null)
            {

                archivo8.SaveAs(Server.MapPath("~/Imagen/" + archivo8.FileName));
                objEvidencia.Archivo_Material8 = archivo8.FileName;
                objEvidencia.TipoArchivo_Material8 = Path.GetExtension(archivo8.FileName);
                objEvidencia.PesoArchivo_Material8 = Convert.ToString(Math.Round((Convert.ToDecimal(archivo8.ContentLength) / (1024 * 1024)), 2)) + " Mb";
            }
            if (archivo9 != null)
            {

                archivo9.SaveAs(Server.MapPath("~/Imagen/" + archivo9.FileName));
                objEvidencia.Archivo_Material9 = archivo9.FileName;
                objEvidencia.TipoArchivo_Material9 = Path.GetExtension(archivo9.FileName);
                objEvidencia.PesoArchivo_Material9 = Convert.ToString(Math.Round((Convert.ToDecimal(archivo9.ContentLength) / (1024 * 1024)), 2)) + " Mb";
            }
            if (archivo10 != null)
            {

                archivo10.SaveAs(Server.MapPath("~/Imagen/" + archivo10.FileName));
                objEvidencia.Archivo_Material10 = archivo10.FileName;
                objEvidencia.TipoArchivo_Material10 = Path.GetExtension(archivo10.FileName);
                objEvidencia.PesoArchivo_Material10 = Convert.ToString(Math.Round((Convert.ToDecimal(archivo10.ContentLength) / (1024 * 1024)), 2)) + " Mb";
            }
            objEvidencia.Guardar();
            return Redirect("~/AreaDocente/PortafolioU1Docente/Agregar/" + Codigo_detalle_carga);
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
            return Redirect("~/AreaDocente/PortafolioU1Docente/Agregar/" + Codigo_detalle_carga);
        }

        public ActionResult Guardar(Tbl_Portafolio objPortafolioU1, int idprueba, int retirados, int abandonos, int aprobados, int codigo, string estado, string unidad)
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
            return Redirect("~/AreaDocente/PortafolioU1Docente/Agregar/" + codigo);

            //}
            //else
            //{
            //    return View("~/Views/PruebaEntrada/Agregar.cshtml");
            //}

        }

        public ActionResult Guardar1(Tbl_Material objmaterial, int idprueba, string material, string tipo, string evidencia, int cantidad, string descripcion, int codigo)
        {


            objmaterial.Codigo_Portafolio = idprueba;
            objmaterial.Nombre_Material1 = material;
            objmaterial.Estado_Material1 = tipo;
            //objmaterial.Archivo_Material = evidencia;
            objmaterial.Cantidad_Material1 = cantidad;
            objmaterial.Descripcion_Material1 = descripcion;
            objmaterial.Tipo_Material = "ESTUDIANTE";

            objmaterial.Guardar();
            return Redirect("~/AreaDocente/PortafolioU1Docente/Agregar/" + codigo);
        }

        public ActionResult GuardarEstado(Tbl_Portafolio objPortafolio, int id = 0, int codigodetalle = 0, string unidad=null,int retirados=0,int abandono=0, int aprobados=0,string estado = null,int iddocente=0)
        {



            objPortafolio.Estado_Portafolio = estado;

            objPortafolio.Codigo_Portafolio= id;
            objPortafolio.Codigo_DetalleCargaAcademica = codigodetalle;
           objPortafolio.Unidad_Portafolio= unidad;
            objPortafolio.Retirados_Portafolio = retirados;
            objPortafolio.Abandono_Portafolio = abandono;
            objPortafolio.Aprobados_Portafolio = aprobados;
            objPortafolio.Fecha_Portafolio = DateTime.Now;
            objPortafolio.Guardar();

            return Redirect("~/AreaDocente/MiCargaAcademica/VerDocente/" + iddocente);

        }

        [HttpPost]
        public ActionResult CargarImagen(Tbl_Material objmaterial, HttpPostedFileBase evidenciae)
        {
            if (ModelState.IsValid)
            {

                if (evidenciae != null)
                {
                    string archivo = (evidenciae.FileName).ToLower();

                    evidenciae.SaveAs(Server.MapPath("~/Imagen/" + evidenciae.FileName));
                    objmaterial.Archivo_Material1 = evidenciae.FileName;
                }

                objmaterial.Guardar();
                return Redirect("~/AreaDocente/PortafolioU1Docente/Agregar/");
            }
            else
            {
                return View("~/AreaDocente/MiCargaAcademica/Agregar.cshtml");
            }
        }
        //parte guimer PDF

        // Metodo para Imprimir PDF Docente
        public ActionResult ListaPDFPortafolioU1(int id)
        {
            //ViewBag.prueba = objPruebaEntrada.Listar();
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
        public ActionResult ExportaAPDF(int id)
        {
            return new ActionAsPdf("ListaPDFPortafolioU1/" + id);
        }
    }
}