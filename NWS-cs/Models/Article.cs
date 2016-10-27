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

        // Thanks to http://stackoverflow.com/a/9398315
        public string ShortText
        {
            get
            {
                if (text == null)
                {
                    return "";
                }
                else if (text.Length <= 100)
                {
                    return text;
                }
                else
                {
                    return text.Substring(0, 100) + "...";
                }
            }
        }

    }
}
