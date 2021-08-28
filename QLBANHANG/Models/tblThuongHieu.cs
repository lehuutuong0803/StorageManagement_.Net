namespace QLBANHANG.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblThuongHieu")]
    public partial class tblThuongHieu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblThuongHieu()
        {
            tblGiays = new HashSet<tblGiay>();
        }

        [Key]
        [StringLength(50)]
        public string MaThuongHieu { get; set; }

        [Required]
        [StringLength(50)]
        public string TenThuongHieu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblGiay> tblGiays { get; set; }
    }
}
