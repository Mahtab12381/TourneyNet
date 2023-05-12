using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class EventDTO
    {
        public int event_id { get; set; }

        public int organizer_id { get; set; }

        public string event_name { get; set; }
        public string event_description { get; set; }

        public DateTime event_start_date { get; set; }
        public DateTime event_end_date { get; set; }

        public string location { get; set; }


        public string rules { get; set; }

        public string prizes { get; set; }

        public DateTime registration_deadline { get; set; }
    }
}
