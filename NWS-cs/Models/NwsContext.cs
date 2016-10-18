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

        public virtual DbSet<Advertisement> Advertisement { get; set; }
        public virtual DbSet<Archive> Archive { get; set; }
        public virtual DbSet<Article> Article { get; set; }
        public virtual DbSet<Feature> Feature { get; set; }
        public virtual DbSet<Officer> Officer { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<Video> Video { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>()
                .Property(e => e.hfso)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
