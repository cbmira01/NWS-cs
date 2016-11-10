using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NWS_cs
{
    public partial class Archive
    {
        public Archive()
        {
            DateTime now = DateTime.Now;
            title = "New Archive Title: " + now.ToString();
        }

        public int id { get; set; }

        [DisplayName("Archive Title")]
        [Required(ErrorMessage = "Archive title is required")]
        public string title { get; set; }

        [DisplayName("Archive Link")]
        [Required(ErrorMessage = "Archive link is required")]
        public string link { get; set; }
    }
}
