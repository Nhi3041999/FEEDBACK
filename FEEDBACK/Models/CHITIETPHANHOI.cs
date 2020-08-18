namespace FEEDBACK.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETPHANHOI")]
    public partial class CHITIETPHANHOI
    {
        [Key]
        public int MA_CTPH { get; set; }

        public int MAKH { get; set; }

        public int MACH { get; set; }

        public int MAKS { get; set; }

        public int MADG { get; set; }

        public virtual CAUHOI CAUHOI { get; set; }

        public virtual DANHGIA DANHGIA { get; set; }

        public virtual DM_KHACHSAN DM_KHACHSAN { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
