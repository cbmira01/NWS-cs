namespace NWS_cs
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("officers_t")]
    public partial class Officers
    {
        public int id { get; set; }

        public string name { get; set; }

        public string email { get; set; }

        public string description { get; set; }

        public string photo { get; set; }
    }
}
