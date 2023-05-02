using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class TeamCommunicationDTO
    {
       
        public int Communication_id { get; set; }
        public int Team_id { get; set; }

        
        public int Sender_id { get; set; }

        
        public int Receiver_id { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
