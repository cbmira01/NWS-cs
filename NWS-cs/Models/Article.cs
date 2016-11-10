using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NWS_cs
{
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

        [DisplayName("Article UUID")]
        [Required(ErrorMessage = "Article UUID is required")]
        public string uuid { get; set; }

        // hfso indicates an image that is hidden for small media only
        [DisplayName("Hide Image for Small Media Only")]
        [Required(ErrorMessage = "HFSO is required")]
        public bool hfso { get; set; }

        [DisplayName("Article Title")]
        [Required(ErrorMessage = "Article title is required")]
        public string title { get; set; }

        [DisplayName("Article Image")]
        [Required(ErrorMessage = "Article image is required")]
        public string image { get; set; }

        // Thanks to http://stackoverflow.com/a/4927032
        [DisplayName("Article Text")]
        [DataType(DataType.MultilineText)]
        public string text { get; set; }

    }
}
