namespace PortafolioEPIS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    using System.Linq;
    using System.Data.Entity;

    using System.Data.Entity.Validation;
    using System.Web;
    using System.IO;

    public partial class Tbl_Usuario
    {
        [Key]
        public int Codigo_Usuario { get; set; }

        public int Codigo_Docente { get; set; }

        [StringLength(100)]
        public string Nombre_Usuario { get; set; }

        [StringLength(100)]
        public string Password_Usuario { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaCreacion_Usuario { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaActualizacion_Usuario { get; set; }

        public bool? Estado_Usuario { get; set; }

        public virtual Tbl_Docente Tbl_Docente { get; set; }

        //Metodo listar
        public List<Tbl_Usuario> Listar()//Retorna una coleccion de registros
        {
            var objUsuario = new List<Tbl_Usuario>();
            try
            {
                using (var db = new Modelo_Portafolio())
                {
                    objUsuario = db.Tbl_Usuario.Include("Tbl_Docente").ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return objUsuario;
        }

        //Metodo obtener
        public Tbl_Usuario Obtener(int id)//retorna solo un objeto
        {
            var objUsuario = new Tbl_Usuario();
            try
            {
                using (var db = new Modelo_Portafolio())
                {
                    objUsuario = db.Tbl_Usuario.Include("Tbl_Docente")
                                    .Where(x => x.Codigo_Usuario == id)
                                    .SingleOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return objUsuario;
        }

        //Metodo guardar
        public void Guardar()
        {
            try
            {
                using (var db = new Modelo_Portafolio())
                {

                    if (this.Codigo_Usuario > 0)
                    {
                        //si existe un valor mayor que cero es por que existe el registro
                        db.Entry(this).State = EntityState.Modified;
                    }
                    else
                    {
                        //no existe el registro lo graba (Nuevo)
                        db.Entry(this).State = EntityState.Added;

                    }
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //metodo Eliminar
        public void Eliminar()
        {

            try
            {
                using (var db = new Modelo_Portafolio())
                {
                    db.Entry(this).State = EntityState.Deleted;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        //Metodo validar Login
        public ResponseModel ValidarLogin(string Usuario, string Password)
        {
            var rm = new ResponseModel();
            try
            {
                using (var db = new Modelo_Portafolio())
                {
                    Password = HashHelper.SHA1(Password);
                    var usuario = db.Tbl_Usuario.Where(x => x.Nombre_Usuario == Usuario)
                                             .Where(x => x.Password_Usuario == Password)
                                             .SingleOrDefault();
                    if (usuario != null)
                    {
                        SessionHelper.AddUserToSession(usuario.Codigo_Usuario.ToString());
                        rm.SetResponse(true);

                    }
                    else
                    {
                        rm.SetResponse(false, "Usuario o password incorrectos ..");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return rm;
        }

        //Metodo Actualizar perfil Personal 
        //public ResponseModel GuardarPerfil(HttpPostedFileBase Foto)
        //{
        //    var rm = new ResponseModel();
        //    try
        //    {
        //        using (var db = new Modelo_Portafolio())
        //        {
        //            db.Configuration.ValidateOnSaveEnabled = false;
        //            var Usu = db.Entry(this);
        //            Usu.State = EntityState.Modified;

        //            if (Foto != null)
        //            {
        //                string extension = Path.GetExtension(Foto.FileName).ToLower();
        //                int size = 1024 * 1024 * 5;

        //                var filtroextension = new[] { ".jpg", ".jpeg", ".png", ".gif" };
        //                var extensiones = Path.GetExtension(Foto.FileName);

        //                if (filtroextension.Contains(extensiones) && (Foto.ContentLength <= size))
        //                {
        //                    String archivo = Path.GetFileName(Foto.FileName);
        //                    Foto.SaveAs(HttpContext.Current.Server.MapPath("~/Imagenes/" + archivo));

        //                    this.avatar = archivo;
        //                }
        //            }

        //            else Usu.Property(x => x.avatar).IsModified = false;

        //            if (this.usuario_id == 0) Usu.Property(x => x.usuario_id).IsModified = false;
        //            if (this.docente_id == 0) Usu.Property(x => x.docente_id).IsModified = false;
        //            if (this.nombre == null) Usu.Property(x => x.nombre).IsModified = false;
        //            if (this.clave == null) Usu.Property(x => x.clave).IsModified = false;
        //            if (this.nivel == null) Usu.Property(x => x.nivel).IsModified = false;
        //            if (this.estado == null) Usu.Property(x => x.estado).IsModified = false;
        //            db.SaveChanges();
        //            rm.SetResponse(true);

        //        }

        //    }
        //    catch (DbEntityValidationException)
        //    {
        //        throw;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }

        //    return rm;
        //}

    }
}
