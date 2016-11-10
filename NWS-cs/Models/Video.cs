using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NWS_cs
{
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

        [DisplayName("Video Site")]
        [Required(ErrorMessage = "Video site is required")]
        public string site { get; set; }

        [DisplayName("Video Mime Type")]
        public string type { get; set; }

        [DisplayName("Video Title")]
        [Required(ErrorMessage = "Video title is required")]
        public string title { get; set; }

        [DisplayName("Video Description")]
        public string description { get; set; }

        [DisplayName("Video Link")]
        [Required(ErrorMessage = "Video link is required")]
        public string link { get; set; }
    }
}
