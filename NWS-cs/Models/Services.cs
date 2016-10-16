namespace NWS_cs
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("services_t")]
    public partial class Services
    {
        public int id { get; set; }

        public string text { get; set; }
    }
}
