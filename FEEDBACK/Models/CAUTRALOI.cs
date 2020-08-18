namespace FEEDBACK.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CAUTRALOI")]
    public partial class CAUTRALOI
    {
        [Key]
        public int MACTL { get; set; }

        public int MACH { get; set; }

        [Column("CAUTRALOI")]
        public string CAUTRALOI1 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYTAO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYCAPNHAT { get; set; }

        public int MAKH { get; set; }

        public virtual CAUHOI CAUHOI { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
