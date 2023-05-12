using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class SocialMediaSharing
    {
        [Key]
        public int share_id { get; set; }

        public DateTime share_date { get; set; }

        public string platform { get; set; }

        public string share_description  { get; set; }

        [ForeignKey("Event")]
        public int Event_Id { get; set; }
        public virtual Event Event { get; set; }
    }
}
