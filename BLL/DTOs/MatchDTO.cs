using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class MatchDTO
    {
        
        public int Match_id { get; set; }
        
        public int Tournament_id { get; set; }
        public int Match_number { get; set; }


        public DateTime Match_start_time { get; set; }
        public DateTime Match_end_time { get; set; }

        public int Match_winner_team_id { get; set; }
        public int Match_loser_team_id { get; set; }
        public int w_score { get; set; }
        public int l_score { get; set; }

    }
}
