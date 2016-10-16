namespace NWS_cs
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("feature_t")]
    public partial class Feature
    {
        public int id { get; set; }

        public string article { get; set; }

        public string image1 { get; set; }

        public string image2 { get; set; }

        public string image3 { get; set; }

        public string title { get; set; }
    }
}
