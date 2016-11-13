using System;
using System.Data.Entity;

namespace NWS_cs
{
    public partial class NwsContext : DbContext
    {
        public NwsContext()
            : base("name=NwsContext")
        {
        }

        public virtual DbSet<Advertisement> Advertisements { get; set; }
        public virtual DbSet<Archive> Archives { get; set; }
        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Feature> Features { get; set; }

        internal void SqlQuery(string v, object p)
        {
            throw new NotImplementedException();
        }

        public virtual DbSet<Officer> Officers { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Video> Videos { get; set; }

        public virtual DbSet<Jeopardy> JeopardyQuestions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {    
        }
    }
}
