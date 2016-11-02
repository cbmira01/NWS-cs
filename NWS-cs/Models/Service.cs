namespace NWS_cs
{
    using System;

    public partial class Service
    {
        public Service()
        {
            DateTime now = DateTime.Now;
            text = "New Neighborhood Service: " + now.ToString();
        }

        public int id { get; set; }

        public string text { get; set; }
    }
}
