namespace NWS_cs
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Feature
    {
        public int id { get; set; }

        public string article { get; set; }

        public string image1 { get; set; }

        public string image2 { get; set; }

        public string image3 { get; set; }

        public string title { get; set; }

        public string Text50
        {
            get
            {
                if (article == null)
                {
                    return "";
                }
                else
                {
                    return (article.Substring(0, Math.Min(article.Length, 50)) + "...");
                }
            }
        }
    }
}
