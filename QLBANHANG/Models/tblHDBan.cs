namespace QLBANHANG.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblHDBan")]
    public partial class tblHDBan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblHDBan()
        {
            tblCTHDs = new HashSet<tblCTHD>();
        }

        [Key]
        [StringLength(50)]
        public string MaHDBan { get; set; }

        [Required]
        [StringLength(50)]
        public string MaNhanVien { get; set; }

        public DateTime NgayBan { get; set; }

        [Required]
        [StringLength(50)]
        public string MaKhach { get; set; }

        public double TongTien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCTHD> tblCTHDs { get; set; }

        public virtual tblKhachHang tblKhachHang { get; set; }

        public virtual tblNhanVien tblNhanVien { get; set; }
    }
}
