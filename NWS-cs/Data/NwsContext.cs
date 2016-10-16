namespace NWS_cs
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NwsContext : DbContext
    {
        public NwsContext()
            : base("name=NwsContext")
        {
        }

        public virtual DbSet<ads_t> ads_t { get; set; }
        public virtual DbSet<Archives> archives_t { get; set; }
        public virtual DbSet<articles_t> articles_t { get; set; }
        public virtual DbSet<feature_t> feature_t { get; set; }
        public virtual DbSet<officers_t> officers_t { get; set; }
        public virtual DbSet<services_t> services_t { get; set; }
        public virtual DbSet<videos_t> videos_t { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<articles_t>()
                .Property(e => e.hfso)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
