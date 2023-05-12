using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Event
    {
        [Key]
        public int event_id { get; set; }

        public int organizer_id { get; set; }

        public string event_name { get; set; }
        public string event_description { get; set;}

        public DateTime event_start_date { get; set; }
        public DateTime event_end_date { get; set; }

        public string location { get; set;}


        public string rules { get; set;}

        public string prizes { get; set; }

        public DateTime registration_deadline { get; set; }

        public virtual ICollection<Stream> Streams { get; set; }

        //public Event()
        //{
        //    Streams = new List<Stream>();
        //}


        public virtual ICollection<Tournament> Tournaments { get; set; }

        //public Event1()
        //{
        //    Tournaments = new List<Tournament>();
        //}

        public virtual ICollection<SocialMediaSharing> SocialMediaSharings { get; set; }

        //public Event2()
        //{
        //    SocialMediaSharings = new List<SocialMediaSharing>();
        //}

        [ForeignKey("Organizer")]
        public int Organizer_Id { get; set; }
        public virtual Organizer Organizer { get; set; }



    }
}
