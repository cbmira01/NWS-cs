namespace NWS_cs
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ads_t")]
    public partial class Ads
    {
        public int id { get; set; }

        public string link { get; set; }
    }
}
