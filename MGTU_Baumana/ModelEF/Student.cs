namespace MGTU_Baumana.ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            PayReport = new HashSet<PayReport>();
            Receipt = new HashSet<Receipt>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDStudent { get; set; }

        [Required]
        [StringLength(100)]
        public string LustName { get; set; }

        [Required]
        [StringLength(50)]
        public string FirsName { get; set; }

        [StringLength(50)]
        public string Patronomic { get; set; }

        public int SeriesNamber { get; set; }

        [Required]
        [StringLength(10)]
        public string Group { get; set; }

        [Required]
        [StringLength(10)]
        public string Room { get; set; }

        public int Table { get; set; }

        public int OrderOfEnrollment { get; set; }

        public int IDBenefit { get; set; }

        public int IDStatus { get; set; }

        public virtual Benefit Benefit { get; set; }

        public virtual Contract Contract { get; set; }

        public virtual Pasport Pasport { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PayReport> PayReport { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receipt> Receipt { get; set; }
    }
}
