namespace NWS_cs
{
    using System.ComponentModel.DataAnnotations;

    public partial class Feature
    {
        public int id { get; set; }

        // Thanks to http://stackoverflow.com/a/4927032
        [DataType(DataType.MultilineText)]
        public string article { get; set; }

        public string image1 { get; set; }

        public string image2 { get; set; }

        public string image3 { get; set; }

        public string title { get; set; }

    }
}
