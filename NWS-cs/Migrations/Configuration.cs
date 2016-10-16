namespace NWS_cs.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NWS_cs.NwsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(NWS_cs.NwsContext context)
        {

            string line;

            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader("NwsSeedData.sql");
            while ((line = file.ReadLine()) != null)
            {
                context.Database.ExecuteSqlCommand(line);
            }

            context.SaveChanges();
            file.Close();
        }
    }
}
