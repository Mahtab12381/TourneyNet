using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Ranking
    {
        [Key]
        public int ranking_id { get; set; }
        public int Match_palyed { get; set; }
        public int Match_lost { get; set; }
        public int Match_won { get; set; }
        public int Total_point { get; set; }

        [ForeignKey("Participant")]
        public int participant_id { get; set; }
        public virtual Participant Participant { get; set; }
       
        [ForeignKey("Tournaments")]
        public int tournament_id { get; set; }
        public virtual Tournament Tournaments { get; set; }

    }
}
