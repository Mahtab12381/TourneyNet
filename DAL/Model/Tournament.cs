using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public DateTime registration_deadline   { get; set; }
        public string tournament_rules { get; set; }
        public virtual ICollection<Participant> Participants { get; set; }

        //public Participant()
        //{
        //    Participants = new List<Participant>();
        //}

        [ForeignKey("Event")]
        public int Event_Id { get; set; }
        public virtual Event Event { get; set; }



        //public virtual ICollection<Ranking> Rankings { get; set; }

        //public Tournament()
        //{
        //    Rankings = new List<Ranking>();
        //}



    }
}
