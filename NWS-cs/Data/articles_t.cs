namespace NWS_cs
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class articles_t
    {
        public int id { get; set; }

        public string uuid { get; set; }

        [StringLength(1)]
        public string hfso { get; set; }

        public string title { get; set; }

        public string image { get; set; }

        public string text { get; set; }
    }
}
