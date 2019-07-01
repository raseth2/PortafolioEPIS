namespace PortafolioEPIS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    using System.Linq;
    using System.Data.Entity;

    public partial class Tbl_DetalleCargaAcademica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_DetalleCargaAcademica()
        {
            Tbl_InformeFinal = new HashSet<Tbl_InformeFinal>();
            Tbl_Portafolio = new HashSet<Tbl_Portafolio>();
            Tbl_PruebaEntrada = new HashSet<Tbl_PruebaEntrada>();
        }

        [Key]
        public int Codigo_DetalleCargaAcademica { get; set; }

        public int Codigo_PlanEstudio { get; set; }

        public int Codigo_CargaAcademica { get; set; }

        public int Codigo_Docente { get; set; }

        public int Codigo_Seccion { get; set; }

        public int Codigo_DetallePlanEstudio { get; set; }

        public int Codigo_Semestre { get; set; }

        public int Matriculados_DetalleCargaAcademica { get; set; }

        [StringLength(250)]
        public string URL_DetalleCargaAcademica { get; set; }

        public bool Estado_DetalleCargaAcademica { get; set; }

        public virtual Tbl_CargaAcademica Tbl_CargaAcademica { get; set; }

        public virtual Tbl_PlanEstudio Tbl_PlanEstudio { get; set; }

        public virtual Tbl_Docente Tbl_Docente { get; set; }

        public virtual Tbl_Seccion Tbl_Seccion { get; set; }

        public virtual Tbl_DetallePlanEstudio Tbl_DetallePlanEstudio { get; set; }

        public virtual Tbl_Semestre Tbl_Semestre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_InformeFinal> Tbl_InformeFinal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Portafolio> Tbl_Portafolio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_PruebaEntrada> Tbl_PruebaEntrada { get; set; }
    }
}
