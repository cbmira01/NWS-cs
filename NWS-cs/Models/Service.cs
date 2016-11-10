using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NWS_cs
{
    public partial class Service
    {
        public Service()
        {
            DateTime now = DateTime.Now;
            text = "New Neighborhood Service: " + now.ToString();
        }

        public int id { get; set; }

        [DisplayName("Service Text")]
        [Required(ErrorMessage = "Service text is required")]
        public string text { get; set; }
    }
}
