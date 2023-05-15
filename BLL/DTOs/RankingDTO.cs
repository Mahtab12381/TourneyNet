using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class RankingDTO
    {
        public int ranking_id { get; set; }

        public int Match_palyed { get; set; }
        public int Match_lost { get; set; }
        public int Match_won { get; set; }
        public int Total_point { get; set; }

        public int participant_id { get; set; }
        public int tournament_id { get; set; }

        public string team_name { get; set; }
    }
}
