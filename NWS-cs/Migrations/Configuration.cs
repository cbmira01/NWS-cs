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
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NWS_cs.NwsContext context)
        {

            int counter = 0;
            string line;

            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader("NwsSeedData.sql");
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine("{0}: {1}", counter, line);
                counter++;
            }

            file.Close();


/*           
           var adList = new List<Advertisements>
            {
                new Advertisements { },
            };
            adList.ForEach(s => context.Advertisements.AddOrUpdate(i => i.id, s));
            context.SaveChanges();

*/
        }
    }
}
