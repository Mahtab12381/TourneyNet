using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class TournamentDTO
    {
        public int tournament_id { get; set; }
        public string tournament_name { get; set; }
        public string tournament_description { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        public DateTime registration_deadline { get; set; }
        public string tournament_rules { get; set; }
    }
}
