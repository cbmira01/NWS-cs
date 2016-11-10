namespace NWS_cs
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Feature
    {
        public Feature()
        {
            DateTime now = DateTime.Now;
            title = "New Feature Title: " + now.ToString();

            image1 = "Content/Images/no_cat.jpg";
            image2 = "Content/Images/no_cat.jpg";
            image3 = "Content/Images/no_cat.jpg";
        }

        public int id { get; set; }

        // Thanks to http://stackoverflow.com/a/4927032
        [DisplayName("Feature Article")]
        [DataType(DataType.MultilineText)]
        public string article { get; set; }

        [DisplayName("Feature Image 1")]
        [Required(ErrorMessage = "Image location is required")]
        public string image1 { get; set; }

        [DisplayName("Feature Image 2")]
        [Required(ErrorMessage = "Image location is required")]
        public string image2 { get; set; }

        [DisplayName("Feature Image 3")]
        [Required(ErrorMessage = "Image location is required")]
        public string image3 { get; set; }

        [DisplayName("Feature Title")]
        [Required(ErrorMessage = "Title is required")]
        public string title { get; set; }

    }
}
