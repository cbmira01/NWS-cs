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

        public virtual DbSet<Advertisements> ads_t { get; set; }
        public virtual DbSet<Archives> archives_t { get; set; }
        public virtual DbSet<Articles> articles_t { get; set; }
        public virtual DbSet<Feature> feature_t { get; set; }
        public virtual DbSet<Officers> officers_t { get; set; }
        public virtual DbSet<Services> services_t { get; set; }
        public virtual DbSet<Videos> videos_t { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Articles>()
                .Property(e => e.hfso)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
