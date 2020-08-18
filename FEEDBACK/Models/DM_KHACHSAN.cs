namespace FEEDBACK.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DM_KHACHSAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DM_KHACHSAN()
        {
            CHITIETPHANHOIs = new HashSet<CHITIETPHANHOI>();
        }

        [Key]
        public int MAKS { get; set; }

        [StringLength(50)]
        public string TENCOSO { get; set; }

        public int? SOPHONG { get; set; }

        public int? SOGIUONG { get; set; }

        public string DIACHI { get; set; }

        [StringLength(50)]
        public string SDT { get; set; }

        public string EMAIL { get; set; }

        public string GHICHU { get; set; }

        [Required]
        [StringLength(10)]
        public string MALOAI_KS { get; set; }

        public bool? TRANGTHAI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETPHANHOI> CHITIETPHANHOIs { get; set; }

        public virtual LOAIKHACHSAN LOAIKHACHSAN { get; set; }
    }
}
