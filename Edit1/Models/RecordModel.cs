namespace Edit1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RecordModel : DbContext
    {
        public RecordModel()
            : base("name=RecordModel")
        {
        }

        public virtual DbSet<Record> Records { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Record>()
                .Property(e => e.Description)
                .IsUnicode(false);
        }
    }
}
