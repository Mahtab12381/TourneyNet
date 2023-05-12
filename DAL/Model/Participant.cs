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
        public int tournament_id { get; set; }
        public int player_id { get; set; }
        public string team_name { get; set;}
        public string team_logo { get; set;}

        public virtual ICollection<Payment> Payments { get; set; }

        public Participant()
        {
            Payments = new List<Payment>();
        }


        public virtual ICollection<Ranking> Rankings { get; set; }

        //public Participant()
        //{
        //    Rankings = new List<Ranking>();
        //}

        [ForeignKey("Tournament")]
        public int Tournament_id { get; set; }
        public virtual Tournament Tournament { get; set; }



    }
}
