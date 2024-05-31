namespace MGTU_Baumana.ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pasport")]
    public partial class Pasport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pasport()
        {
            Student = new HashSet<Student>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SeriesNumber { get; set; }

        [Required]
        [StringLength(200)]
        public string IssuedByWhom { get; set; }

        [Column(TypeName = "date")]
        public DateTime WhoIssued { get; set; }

        public int DivisionCode { get; set; }

        [Required]
        [StringLength(200)]
        public string Registration { get; set; }

        [Required]
        [StringLength(10)]
        public string Grazhanstvo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Student { get; set; }
    }
}
