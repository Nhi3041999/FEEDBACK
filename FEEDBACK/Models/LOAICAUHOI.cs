namespace FEEDBACK.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAICAUHOI")]
    public partial class LOAICAUHOI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAICAUHOI()
        {
            CAUHOIs = new HashSet<CAUHOI>();
        }

        [Key]
        public int MALOAICAUHOI { get; set; }

        [Column("LOAICAUHOI")]
        public string LOAICAUHOI1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAUHOI> CAUHOIs { get; set; }
    }
}
