namespace NWS_cs
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class Article
    {
        public Article()
        {
            hfso = false;

            DateTime now = DateTime.Now;
            title = "New Article Title: " + now.ToString();

            Guid g = Guid.NewGuid();
            uuid = g.ToString();
        }

        public int id { get; set; }

        public string uuid { get; set; }

        // hfso indicates an image that is hidden for small media only
        public bool hfso { get; set; }

         public string title { get; set; }

        public string image { get; set; }

        // Thanks to http://stackoverflow.com/a/4927032
        [DataType(DataType.MultilineText)]
        public string text { get; set; }

    }
}
