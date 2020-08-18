namespace FEEDBACK.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CAUHOI")]
    public partial class CAUHOI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CAUHOI()
        {
            CAUTRALOIs = new HashSet<CAUTRALOI>();
            CHITIETPHANHOIs = new HashSet<CHITIETPHANHOI>();
        }

        [Key]
        public int MACH { get; set; }

        [Column("CAUHOI")]
        public string CAUHOI1 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYTAO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYCAPNHAT { get; set; }

        public bool? TRANGTHAI { get; set; }

        public int? MALOAICAUHOI { get; set; }

        [Required]
        [StringLength(50)]
        public string TAIKHOAN { get; set; }

        public virtual DANGNHAP DANGNHAP { get; set; }

        public virtual LOAICAUHOI LOAICAUHOI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAUTRALOI> CAUTRALOIs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETPHANHOI> CHITIETPHANHOIs { get; set; }
    }
}
