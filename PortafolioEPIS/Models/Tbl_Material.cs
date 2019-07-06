namespace PortafolioEPIS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    using System.Linq;
    using System.Data.Entity;

    public partial class Tbl_Material
    {
        [Key]
        public int Codigo_Material { get; set; }

        public int Codigo_Portafolio { get; set; }

        [StringLength(21)]
        public string Tipo_Material { get; set; }

        [StringLength(250)]
        public string UrlOnline_Material { get; set; }

        [StringLength(250)]
        public string Nombre_Material1 { get; set; }

        [StringLength(21)]
        public string Estado_Material1 { get; set; }

        public int? Cantidad_Material1 { get; set; }

        [StringLength(250)]
        public string Archivo_Material1 { get; set; }

        [StringLength(10)]
        public string TipoArchivo_Material1 { get; set; }

        [StringLength(50)]
        public string PesoArchivo_Material1 { get; set; }

        [StringLength(250)]
        public string Descripcion_Material1 { get; set; }

        [StringLength(250)]
        public string Nombre_Material2 { get; set; }

        [StringLength(21)]
        public string Estado_Material2 { get; set; }

        public int? Cantidad_Material2 { get; set; }

        [StringLength(250)]
        public string Archivo_Material2 { get; set; }

        [StringLength(10)]
        public string TipoArchivo_Material2 { get; set; }

        [StringLength(50)]
        public string PesoArchivo_Material2 { get; set; }

        [StringLength(250)]
        public string Descripcion_Material2 { get; set; }

        [StringLength(250)]
        public string Nombre_Material3 { get; set; }

        [StringLength(21)]
        public string Estado_Material3 { get; set; }

        public int? Cantidad_Material3 { get; set; }

        [StringLength(250)]
        public string Archivo_Material3 { get; set; }

        [StringLength(10)]
        public string TipoArchivo_Material3 { get; set; }

        [StringLength(50)]
        public string PesoArchivo_Material3 { get; set; }

        [StringLength(250)]
        public string Descripcion_Material3 { get; set; }

        [StringLength(250)]
        public string Nombre_Material4 { get; set; }

        [StringLength(21)]
        public string Estado_Material4 { get; set; }

        public int? Cantidad_Material4 { get; set; }

        [StringLength(250)]
        public string Archivo_Material4 { get; set; }

        [StringLength(10)]
        public string TipoArchivo_Material4 { get; set; }

        [StringLength(50)]
        public string PesoArchivo_Material4 { get; set; }

        [StringLength(250)]
        public string Descripcion_Material4 { get; set; }

        [StringLength(250)]
        public string Nombre_Material5 { get; set; }

        [StringLength(21)]
        public string Estado_Material5 { get; set; }

        public int? Cantidad_Material5 { get; set; }

        [StringLength(250)]
        public string Archivo_Material5 { get; set; }

        [StringLength(10)]
        public string TipoArchivo_Material5 { get; set; }

        [StringLength(50)]
        public string PesoArchivo_Material5 { get; set; }

        [StringLength(250)]
        public string Descripcion_Material5 { get; set; }

        [StringLength(250)]
        public string Nombre_Material6 { get; set; }

        [StringLength(21)]
        public string Estado_Material6 { get; set; }

        public int? Cantidad_Material6 { get; set; }

        [StringLength(250)]
        public string Archivo_Material6 { get; set; }

        [StringLength(10)]
        public string TipoArchivo_Material6 { get; set; }

        [StringLength(50)]
        public string PesoArchivo_Material6 { get; set; }

        [StringLength(250)]
        public string Descripcion_Material6 { get; set; }

        [StringLength(250)]
        public string Nombre_Material7 { get; set; }

        [StringLength(21)]
        public string Estado_Material7 { get; set; }

        public int? Cantidad_Material7 { get; set; }

        [StringLength(250)]
        public string Archivo_Material7 { get; set; }

        [StringLength(10)]
        public string TipoArchivo_Material7 { get; set; }

        [StringLength(50)]
        public string PesoArchivo_Material7 { get; set; }

        [StringLength(250)]
        public string Descripcion_Material7 { get; set; }

        [StringLength(250)]
        public string Nombre_Material8 { get; set; }

        [StringLength(21)]
        public string Estado_Material8 { get; set; }

        public int? Cantidad_Material8 { get; set; }

        [StringLength(250)]
        public string Archivo_Material8 { get; set; }

        [StringLength(10)]
        public string TipoArchivo_Material8 { get; set; }

        [StringLength(50)]
        public string PesoArchivo_Material8 { get; set; }

        [StringLength(250)]
        public string Descripcion_Material8 { get; set; }

        [StringLength(250)]
        public string Nombre_Material9 { get; set; }

        [StringLength(21)]
        public string Estado_Material9 { get; set; }

        public int? Cantidad_Material9 { get; set; }

        [StringLength(250)]
        public string Archivo_Material9 { get; set; }

        [StringLength(10)]
        public string TipoArchivo_Material9 { get; set; }

        [StringLength(50)]
        public string PesoArchivo_Material9 { get; set; }

        [StringLength(250)]
        public string Descripcion_Material9 { get; set; }

        [StringLength(250)]
        public string Nombre_Material10 { get; set; }

        [StringLength(21)]
        public string Estado_Material10 { get; set; }

        public int? Cantidad_Material10 { get; set; }

        [StringLength(250)]
        public string Archivo_Material10 { get; set; }

        [StringLength(10)]
        public string TipoArchivo_Material10 { get; set; }

        [StringLength(50)]
        public string PesoArchivo_Material10 { get; set; }

        [StringLength(250)]
        public string Descripcion_Material10 { get; set; }

        public virtual Tbl_Portafolio Tbl_Portafolio { get; set; }

        public List<Tbl_Material> Listar(int id)//Retorna una coleccion de registros
        {
            var objTbl_Material = new List<Tbl_Material>();
            try
            {
                using (var db = new Modelo_Portafolio())
                {
                    objTbl_Material = db.Tbl_Material.Include("Tbl_Portafolio")
                        .Where(x => x.Codigo_Portafolio == id).ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return objTbl_Material;
        }


        public List<Tbl_Material> Listar1()//Retorna una coleccion de registros
        {
            var objMaterial = new List<Tbl_Material>();
            try
            {
                using (var db = new Modelo_Portafolio())
                {
                    objMaterial = db.Tbl_Material.Include("Tbl_Portafolio").ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return objMaterial;
        }
        //metodo obtener
        public Tbl_Material Obtener(int id)//retorna solo un objeto
        {
            var objTbl_Material = new Tbl_Material();
            try
            {
                using (var db = new Modelo_Portafolio())
                {
                    objTbl_Material = db.Tbl_Material
                        .Where(x => x.Codigo_Portafolio == id)
                        .SingleOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return objTbl_Material;
        }


        //metodo guardar
        public void Guardar()//retorna solo un objeto
        {

            try
            {
                using (var db = new Modelo_Portafolio())
                {
                    if (this.Codigo_Material > 0)
                    {
                        //si existe un valor mayor a 0 es porque existe un registro
                        db.Entry(this).State = EntityState.Modified;

                    }
                    else
                    {
                        //si no existe registro graba(nuevo registro)
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

        ////obtener evidencia id
        //public Tbl_Material ObtenerEvidencia(int id)//retorna solo un objeto
        //{
        //    var objTbl_Material = new Tbl_Material();
        //    try
        //    {
        //        using (var db = new Modelo_Portafolio())
        //        {
        //            objTbl_Material = db.Tbl_Material
        //                .Where(x => x.Codigo_Portafolio == id)
        //                .SingleOrDefault();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //    return objTbl_Material;
        //}
        //}
    }
}
