namespace NWS_cs
{
    using System;

    public partial class Officer
    {
        public Officer()
        {
            DateTime now = DateTime.Now;
            name = "New Officer Name: " + now.ToString();

            photo = "Content/Images/no_cat.jpg";
        }

        public int id { get; set; }

        public string name { get; set; }

        public string email { get; set; }

        public string description { get; set; }

        public string photo { get; set; }
    }
}
