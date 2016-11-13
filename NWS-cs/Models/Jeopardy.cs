using System.ComponentModel;

namespace NWS_cs
{
    public partial class Jeopardy
    {
        public int id { get; set; }

        [DisplayName("Category")]
        public string category { get; set; }

        [DisplayName("Air Date")]
        public string air_date { get; set; }

        [DisplayName("Question")]
        public string question { get; set; }

        [DisplayName("Value")]
        public string value { get; set; }

        [DisplayName("Answer")]
        public string answer { get; set; }

        [DisplayName("Jeopardy Round")]
        public string round { get; set; }

        [DisplayName("Show Number")]
        public string show_number { get; set; }

    }
}
