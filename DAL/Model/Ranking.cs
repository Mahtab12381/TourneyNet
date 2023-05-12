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
        public int rank { get; set; }

        [ForeignKey("Participant")]
        public int participant_id { get; set; }
        public virtual Participant Participant { get; set; }


        [ForeignKey("Tournament")]
        public int T_Id { get; set; }
        public virtual Tournament Tournament { get; set; }
    }
}
