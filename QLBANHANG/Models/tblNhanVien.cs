namespace QLBANHANG.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblNhanVien")]
    public partial class tblNhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblNhanVien()
        {
            tblHDBans = new HashSet<tblHDBan>();
        }

        [Key]
        [StringLength(50)]
        public string MaNhanVien { get; set; }

        public int IDTaiKhoan { get; set; }

        [Required]
        [StringLength(50)]
        public string TenNhanVien { get; set; }

        [Required]
        [StringLength(50)]
        public string GioiTinh { get; set; }

        [Required]
        [StringLength(50)]
        public string DiaChi { get; set; }

        [Required]
        [StringLength(50)]
        public string DienThoai { get; set; }

        public DateTime NgaySinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblHDBan> tblHDBans { get; set; }

        public virtual tblTaiKhoan tblTaiKhoan { get; set; }
    }
}
