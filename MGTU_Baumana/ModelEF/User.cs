namespace MGTU_Baumana.ModelEF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDUser { get; set; }

        [StringLength(100)]
        public string LustName { get; set; }

        [StringLength(50)]
        public string FirsName { get; set; }

        [StringLength(50)]
        public string Patronomic { get; set; }

        public int? IDRole { get; set; }

        [StringLength(50)]
        public string Login { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public virtual Role Role { get; set; }
    }
}
