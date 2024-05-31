namespace MGTU_Baumana.ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PayReport")]
    public partial class PayReport
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDPayReport { get; set; }

        public int? IDReceipt { get; set; }

        public int? IDContract { get; set; }

        public int? IDStudent { get; set; }

        public virtual Contract Contract { get; set; }

        public virtual Receipt Receipt { get; set; }

        public virtual Student Student { get; set; }
    }
}
