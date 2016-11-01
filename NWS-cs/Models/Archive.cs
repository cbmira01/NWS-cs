namespace NWS_cs
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Archive
    {
        public Archive()
        {
            DateTime now = DateTime.Now;
            title = "New Archive Title: " + now.ToString();
        }

        public int id { get; set; }

        public string title { get; set; }

        public string link { get; set; }
    }
}
