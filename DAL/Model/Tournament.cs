using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Tournament
    {
        [Key]
        public int tournament_id { get; set; }
        public string tournament_name { get; set; }
        public string tournament_description { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        public DateTime registration_deadline { get; set; }
        public string tournament_rules { get; set; }
        public string Prize { get; set; }

        public virtual ICollection<Participant> Participants { get; set; }

        [ForeignKey("Registration")]
        public int Organizer_Id { get; set; }
        public virtual Registration Registration { get; set; }

        public virtual ICollection<Ranking> Rankings { get; set; }
        public virtual ICollection<Match> Matches { get; set; }

        public Tournament()
        {
            Rankings = new List<Ranking>();
            Participants = new List<Participant>();
            Matches = new List<Match>();
        }
    }
}
