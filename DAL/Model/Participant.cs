using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Participant
    {
        [Key]
        public int participant_id { get; set;}
        
        public string team_name { get; set;}
        public string team_logo { get; set;}

        [ForeignKey("Team")]
        public int team_id { get; set; }
        public virtual Team Team { get; set; }

        [ForeignKey("Tournament")]
        public int Tournament_id { get; set; }
        public virtual Tournament Tournament { get; set; }

       



    }
}
