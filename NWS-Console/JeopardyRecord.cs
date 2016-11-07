namespace NWS_Console
{
    // This is what an eventual Entity Framework model of the Jeopardy data
    // would look like, for the main web application.
    class JeopardyRecord
    {
        // public int id { get; set; }
        public string category { get; set; }
        public string air_date { get; set; }
        public string question { get; set; }
        public string value { get; set; }
        public string answer { get; set; }
        public string round { get; set; }
        public string show_number { get; set; }
    }
}
