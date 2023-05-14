using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ParticipantDTO
    {
        public int participant_id { get; set; }
        public int tournament_id { get; set; }
        public string team_name { get; set; }
        public string team_logo { get; set; }
        public int team_id { get; set; }
    }
}
