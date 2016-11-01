namespace NWS_cs
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Service
    {
        public Service()
        {
            DateTime now = DateTime.Now;
            this.text = "New Neighborhood Service: " + now.ToString();
        }

        public int id { get; set; }

        public string text { get; set; }
    }
}
