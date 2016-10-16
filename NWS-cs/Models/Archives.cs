namespace NWS_cs
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table ("archives_t")]
    public partial class Archives
    {
        public int id { get; set; }

        public string title { get; set; }

        public string link { get; set; }
    }
}
