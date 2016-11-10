using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NWS_cs
{
    public partial class Officer
    {
        public Officer()
        {
            DateTime now = DateTime.Now;
            name = "New Officer Name: " + now.ToString();

            photo = "Content/Images/no_cat.jpg";
        }

        public int id { get; set; }

        [DisplayName("Officer Name")]
        [Required(ErrorMessage = "Officer name is required")]
        public string name { get; set; }

        [DisplayName("Officer Email")]
        [Required(ErrorMessage = "Officer email is required")]
        public string email { get; set; }

        public string description { get; set; }

        public string photo { get; set; }
    }
}
