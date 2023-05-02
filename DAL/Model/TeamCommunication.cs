using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class TeamCommunication
    {
        [Key]
        public int Communication_id { get; set; }
        public int Team_id { get; set; }

        [Required]
        public int Sender_id { get; set; }

        [Required]
        public int Receiver_id { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
