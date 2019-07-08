using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortafolioEPIS.Models.GoogleModels;
using PortafolioEPIS.Models;
using System.IO;
using PortafolioEPIS.Filters;


namespace PortafolioEPIS.Areas.AreaDocente.Controllers.GoogleController
{
    [Autenticado]
    public class GoogleFileController : Controller
    {
        private Tbl_DetalleCargaAcademica objDetalleCargaAcademica = new Tbl_DetalleCargaAcademica();
        public GoogleDriveFilesRepository objGoogle = new GoogleDriveFilesRepository();
        private string UPT = "1e9reGcaJf68ZUplAFLbHARYv8MCG5eBL";
        PortafolioEPIS.Models.Tbl_Usuario usuario = new PortafolioEPIS.Models.Tbl_Usuario().Obtener(PortafolioEPIS.Models.SessionHelper.GetUser());
        [HttpGet]
        public ActionResult GetGoogleDriveFiles(string FolderId, string NameCarpeta)
        {


            ViewBag.folderId = FolderId;
            ViewBag.NombreCarpeta = NameCarpeta;
            return View(GoogleDriveFilesRepository.GetDriveFiles());
        }


    
        [HttpGet]
        public ActionResult GetContainsInFolder(string FolderId)
        {
          if(FolderId == null) {

                GoogleDriveFilesRepository.CreateFolder(usuario.Tbl_Docente.Apellidos_Docente + " " + usuario.Tbl_Docente.Nombres_Docente, UPT);
                FolderId = "1KqzKLCRTPaJWup1mLM496YYsqitaGcRp";

                //List<Tbl_DetalleCargaAcademica> detallecargaA = objDetalleCargaAcademica.Listar();
            
                //List<GoogleDriveFilesRepository> drives = objGoogle.GetContainsInFolder(FolderId);
               

                //foreach (var d in drives)
                //{
                //    string idfol = UPT;
                //    if (d.Name== usuario.Tbl_Docente.Apellidos_Docente + " " + usuario.Tbl_Docente.Nombres_Docente)
                //    {
                //        foreach (var detalle in detallecargaA)
                //        {
                //            if (detalle.Tbl_Docente.Codigo_Docente == usuario.Codigo_Docente)
                //            {
                //                string nombreCurso = detalle.Tbl_DetallePlanEstudio.CodigoCurso_DetallePlanEstudio + " " + detalle.Tbl_DetallePlanEstudio.Asignatura_DetallePlanEstudio;
                //                GoogleDriveFilesRepository.CreateFolder(nombreCurso, idfol);
                //            }
                //        }
                       
                //    }
                //}


            }
            ViewBag.foldeId = FolderId;

            return View(FolderId == null ? GoogleDriveFilesRepository.GetContainsInFolder(FolderId) : GoogleDriveFilesRepository.GetContainsInFolder(FolderId));
        }

        [HttpPost]
        public ActionResult CreateFolder(String FolderName, String IdCarpeta, string FolderId = null)
        {
            GoogleDriveFilesRepository.CreateFolder(FolderName,IdCarpeta);
           
            return Redirect("GetGoogleDriveFiles?FolderId=" + IdCarpeta);
        }


        [HttpPost]
        public ActionResult DeleteFile(GoogleDriveFiles file, string FolderId = null)
        {
            GoogleDriveFilesRepository.DeleteFile(file);
            //ViewBag.folderId = FolderId;
            return Redirect("GetGoogleDriveFiles?FolderId=" + FolderId);
        }

        [HttpPost]
        public ActionResult UploadFile(HttpPostedFileBase file)
        {
            GoogleDriveFilesRepository.FileUpload(file);
            return RedirectToAction("GetGoogleDriveFiles");
        }

        [HttpPost]
        public ActionResult FileUploadInFolder(HttpPostedFileBase file, string FolderId)
        {
            GoogleDriveFilesRepository.FileUploadInFolder(FolderId, file);
            //ViewBag.folderId = FolderId;
            return Redirect("GetGoogleDriveFiles?FolderId=" + FolderId);
        }
        public void DownloadFile(string id)
        {
            string FilePath = GoogleDriveFilesRepository.DownloadGoogleFile(id);


            Response.ContentType = "application/zip";
            Response.AddHeader("Content-Disposition", "attachment; filename=" + Path.GetFileName(FilePath));
            Response.WriteFile(System.Web.HttpContext.Current.Server.MapPath("~/GoogleDriveFiles/" + Path.GetFileName(FilePath)));
            Response.End();
            Response.Flush();
        }
    }
}