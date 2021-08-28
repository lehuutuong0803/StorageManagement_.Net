namespace QLBANHANG.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblGiay")]
    public partial class tblGiay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblGiay()
        {
            tblCTHDs = new HashSet<tblCTHD>();
        }

        [Key]
        [StringLength(50)]
        public string MaGiay { get; set; }

        [Required]
        [StringLength(50)]
        public string TenGiay { get; set; }

        [Required]
        [StringLength(50)]
        public string MaThuongHieu { get; set; }

        public double SoLuong { get; set; }

        public double DonGiaNhap { get; set; }

        public double DonGiaBan { get; set; }

        [StringLength(50)]
        public string Anh { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCTHD> tblCTHDs { get; set; }

        public virtual tblThuongHieu tblThuongHieu { get; set; }
    }
}
