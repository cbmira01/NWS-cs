namespace NWS_cs
{
    using System;

    public partial class Archive
    {
        public Archive()
        {
            DateTime now = DateTime.Now;
            title = "New Archive Title: " + now.ToString();
        }

        public int id { get; set; }

        public string title { get; set; }

        public string link { get; set; }
    }
}
