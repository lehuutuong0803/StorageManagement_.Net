namespace QLBANHANG.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblCTHD")]
    public partial class tblCTHD
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MaHDBan { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MaGiay { get; set; }

        public int SoLuong { get; set; }

        public double DonGia { get; set; }

        public double ThanhTien { get; set; }

        public virtual tblGiay tblGiay { get; set; }

        public virtual tblHDBan tblHDBan { get; set; }
    }
}
