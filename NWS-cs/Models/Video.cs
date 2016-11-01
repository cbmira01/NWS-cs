namespace NWS_cs
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Video
    {
        public Video()
        {
            DateTime now = DateTime.Now;
            title = "New Video Title: " + now.ToString();

            site = "no_video";
            description = "Sorry, no video available.";
            link = "Content/Images/no_cat.jpg";
        }

        public int id { get; set; }

        public string site { get; set; }

        public string type { get; set; }

        public string title { get; set; }

        public string description { get; set; }

        public string link { get; set; }
    }
}
