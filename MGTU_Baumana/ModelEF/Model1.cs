using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MGTU_Baumana.ModelEF
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Benefit> Benefit { get; set; }
        public virtual DbSet<Contract> Contract { get; set; }
        public virtual DbSet<Pasport> Pasport { get; set; }
        public virtual DbSet<PayReport> PayReport { get; set; }
        public virtual DbSet<Receipt> Receipt { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Benefit>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Benefit>()
                .HasMany(e => e.Student)
                .WithRequired(e => e.Benefit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contract>()
                .Property(e => e.Sum)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Contract>()
                .Property(e => e.SumBenefits)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Contract>()
                .HasMany(e => e.Student)
                .WithRequired(e => e.Contract)
                .HasForeignKey(e => e.Table)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pasport>()
                .Property(e => e.IssuedByWhom)
                .IsUnicode(false);

            modelBuilder.Entity<Pasport>()
                .Property(e => e.Registration)
                .IsUnicode(false);

            modelBuilder.Entity<Pasport>()
                .Property(e => e.Grazhanstvo)
                .IsUnicode(false);

            modelBuilder.Entity<Pasport>()
                .HasMany(e => e.Student)
                .WithRequired(e => e.Pasport)
                .HasForeignKey(e => e.SeriesNamber)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Receipt>()
                .Property(e => e.Sum)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Receipt>()
                .Property(e => e.SumOfDebts)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Role>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.LustName)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.FirsName)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Patronomic)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Group)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Room)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Receipt)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.LustName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.FirsName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Patronomic)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
