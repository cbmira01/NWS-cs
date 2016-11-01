namespace NWS_cs
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Advertisement
    {

        public Advertisement()
        {
            link = "Content/Test/DefaultAd.jpg";
        }

        public int id { get; set; }

        public string link { get; set; }
    }
}
