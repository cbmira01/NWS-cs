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

        public virtual DbSet<Advertisements> Advertisements { get; set; }
        public virtual DbSet<Archives> Archives { get; set; }
        public virtual DbSet<Articles> Articles { get; set; }
        public virtual DbSet<Feature> Feature { get; set; }
        public virtual DbSet<Officers> Officers { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<Videos> Videos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Articles>()
                .Property(e => e.hfso)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
