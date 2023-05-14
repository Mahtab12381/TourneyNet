using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Match
    {

        [Key]
        public int Match_id { get; set; }
        [Required]
        public int Match_number { get; set; }

        public DateTime Match_start_time { get; set; }
        public DateTime Match_end_time { get; set; }

        public string Match_winner_Name { get; set; }

        public string Match_loser_Name { get; set; }
        public int w_score { get; set; }
        public int l_score { get; set; }

        public string participant_name_1 { get; set; }

        public string participant_name_2 { get; set; }

        [ForeignKey("Tournament")]
        public int Tournament_id { get; set; }
        public virtual Tournament Tournament { get; set; }
    }
}
