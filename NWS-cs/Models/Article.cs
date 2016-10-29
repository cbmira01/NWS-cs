namespace NWS_cs
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Article
    {
        public int id { get; set; }

        public string uuid { get; set; }

        [StringLength(1)]
        public string hfso { get; set; }

        public string title { get; set; }

        public string image { get; set; }

        public string text { get; set; }

        public string Text50
        {
            get
            {
                if (text == null)
                {
                    return "";
                }
                else
                {
                    return (text.Substring(0, Math.Min(text.Length, 50)) + "...");
                }
            }
        }

        public string Text100
        {
            get
            {
                if (text == null)
                {
                    return "";
                }
                else
                {
                    return (text.Substring(0, Math.Min(text.Length, 100)) + "...");
                }
            }
        }
    }
}
