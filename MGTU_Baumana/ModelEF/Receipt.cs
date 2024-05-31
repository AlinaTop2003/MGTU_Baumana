namespace MGTU_Baumana.ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Receipt")]
    public partial class Receipt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Receipt()
        {
            PayReport = new HashSet<PayReport>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDReceipt { get; set; }

        public int IDStudent { get; set; }

        [Column(TypeName = "money")]
        public decimal Sum { get; set; }

        [Column(TypeName = "money")]
        public decimal SumOfDebts { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PayReport> PayReport { get; set; }

        public virtual Student Student { get; set; }
    }
}
