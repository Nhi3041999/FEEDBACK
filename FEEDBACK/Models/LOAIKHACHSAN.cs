namespace FEEDBACK.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAIKHACHSAN")]
    public partial class LOAIKHACHSAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIKHACHSAN()
        {
            DM_KHACHSAN = new HashSet<DM_KHACHSAN>();
        }

        [Key]
        [StringLength(10)]
        public string MALOAI_KS { get; set; }

        [StringLength(100)]
        public string GHICHU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_KHACHSAN> DM_KHACHSAN { get; set; }
    }
}
