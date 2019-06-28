﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortafolioEPIS.Models;
using System.IO;

namespace PortafolioEPIS.Areas.AreaDocente.Controllers.Informes
{
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
                objEvidencia.Archivo_Material = archivo.FileName;
                objEvidencia.TipoArchivo_Material = Path.GetExtension(archivo.FileName);
                objEvidencia.PesoArchivo_Material = Convert.ToString(Math.Round((Convert.ToDecimal(archivo.ContentLength) / (1024 * 1024)), 2)) + " Mb";
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
                objEvidencia.Archivo_Material = archivo1.FileName;
                objEvidencia.TipoArchivo_Material = Path.GetExtension(archivo1.FileName);
                objEvidencia.PesoArchivo_Material = Convert.ToString(Math.Round((Convert.ToDecimal(archivo1.ContentLength) / (1024 * 1024)), 2)) + " Mb";
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
            objmaterial.Nombre_Material = material;
            objmaterial.Estado_Material = tipo;
            //objmaterial.Archivo_Material = evidencia;
            objmaterial.Cantidad_Material = cantidad;
            objmaterial.Descripcion_Material = descripcion;
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
                    objmaterial.Archivo_Material = evidenciae.FileName;
                }

                objmaterial.Guardar();
                return Redirect("~/AreaDocente/PortafolioU1Docente/Agregar/");
            }
            else
            {
                return View("~/AreaDocente/MiCargaAcademica/Agregar.cshtml");
            }
        }
    }
}