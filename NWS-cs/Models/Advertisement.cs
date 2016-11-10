using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NWS_cs
{
    public partial class Advertisement
    {
        public Advertisement()
        {
            link = "Content/Test/DefaultAd.jpg";
        }

        public int id { get; set; }

        [DisplayName("Advertisement Link")]
        [Required(ErrorMessage = "Advertisement link is required")]
        public string link { get; set; }
    }
}
