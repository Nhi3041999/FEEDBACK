namespace FEEDBACK.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACHHANG")]
    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            CAUTRALOIs = new HashSet<CAUTRALOI>();
            CHITIETPHANHOIs = new HashSet<CHITIETPHANHOI>();
        }

        [Key]
        public int MAKH { get; set; }

        [StringLength(100)]
        public string TENKH { get; set; }

        [StringLength(50)]
        public string SDT { get; set; }

        public string DIACHI { get; set; }

        public int? GIOITINH { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYSINH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAUTRALOI> CAUTRALOIs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETPHANHOI> CHITIETPHANHOIs { get; set; }
    }
}
