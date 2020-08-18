namespace FEEDBACK.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DANGNHAP")]
    public partial class DANGNHAP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DANGNHAP()
        {
            CAUHOIs = new HashSet<CAUHOI>();
        }

        [Key]
        [StringLength(50)]
        public string TAIKHOAN { get; set; }

        [StringLength(50)]
        public string MATKHAU { get; set; }

        [StringLength(100)]
        public string TENHIENTHI { get; set; }

        public int? VAITRO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAUHOI> CAUHOIs { get; set; }
    }
}
