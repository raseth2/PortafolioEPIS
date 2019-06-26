namespace PortafolioEPIS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    using System.Linq;
    using System.Data.Entity;

    public partial class Tbl_Docente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Docente()
        {
            Tbl_DetalleCargaAcademica = new HashSet<Tbl_DetalleCargaAcademica>();
            Tbl_Usuario = new HashSet<Tbl_Usuario>();
        }

        [Key]
        public int Codigo_Docente { get; set; }

        [Required]
        [StringLength(6)]
        public string Codigo_Docenteepis { get; set; }

        public int Codigo_CargoDocente { get; set; }

        public int Codigo_Profesion { get; set; }

        [Required]
        [StringLength(8)]
        public string DNI_Docente { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombres_Docente { get; set; }

        [Required]
        [StringLength(100)]
        public string Apellidos_Docente { get; set; }

        public bool Sexo_Docente { get; set; }

        [StringLength(30)]
        public string EstadoCivil_Docente { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha Nacimiento")]
        public DateTime? FechaNac_Docente { get; set; }

        [Required]
        [StringLength(200)]
        public string DireccionActual_Docente { get; set; }

        [StringLength(200)]
        public string DireccionReferencia_Docente { get; set; }

        [Required]
        [StringLength(100)]
        public string Correo_Docente { get; set; }

        [StringLength(9)]
        public string TelefonoFijo_Docente { get; set; }

        [Required]
        [StringLength(9)]
        public string TelefonoCelular_Docente { get; set; }

        [StringLength(250)]
        public string Foto_Docente { get; set; }

        public bool Estado_Docente { get; set; }

        public virtual Tbl_CargoDocente Tbl_CargoDocente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_DetalleCargaAcademica> Tbl_DetalleCargaAcademica { get; set; }

        public virtual Tbl_Profesion Tbl_Profesion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Usuario> Tbl_Usuario { get; set; }

        public List<Tbl_Docente> Listar2()//retorna una coleccion
        {
            var objDocente = new List<Tbl_Docente>();
            try
            {
                using (var db = new Modelo_Portafolio())
                {
                    objDocente = db.Tbl_Docente.Include("Tbl_Profesion").Include("Tbl_CargoDocente").ToList();

                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return objDocente;
        }

        //Metodo Listar
        public List<Tbl_Docente> Listar()
        {
            var objDocente = new List<Tbl_Docente>();
            try
            {
                using (var db = new Modelo_Portafolio())
                {
                    objDocente = db.Tbl_Docente.Include("Tbl_Profesion").Include("Tbl_CargoDocente").ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return objDocente;
        }

        //Metodo Obtener
        public Tbl_Docente Obtener(int id)//retorna solo un objeto
        {
            var objDocente = new Tbl_Docente();
            try
            {
                using (var db = new Modelo_Portafolio())
                {
                    objDocente = db.Tbl_Docente.Include("Tbl_Profesion").Include("Tbl_CargoDocente")
                                    .Where(x => x.Codigo_Docente == id)
                                    .SingleOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return objDocente;
        }

        //Metodo Guardar

        public void Guardar()
        {
            try
            {
                using (var db = new Modelo_Portafolio())
                {

                    if (this.Codigo_Docente > 0)
                    {
                        //si existe un valor mayor que cero es por que existe el registro
                        db.Entry(this).State = EntityState.Modified;
                    }
                    else
                    {
                        ///no existe el registro lo graba (Nuevo)
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
                    db.Entry(this).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
