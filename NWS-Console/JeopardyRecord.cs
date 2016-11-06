using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWS_Console
{
    // This is what an eventual Entity Framework model
    // would look like, for the main web application.
    class JeopardyRecord
    {
        public string category { get; set; }
        public string air_date { get; set; }
        public string question { get; set; }
        public string value { get; set; }
        public string answer { get; set; }
        public string round { get; set; }
        public string show_number { get; set; }
    }
}
