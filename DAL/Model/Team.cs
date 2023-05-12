using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Team
    {
        [Key]
        public int Team_id { get; set; }
        [Required]
        public string Team_name { get; set; }
        [Required]
        public string Team_logo { get; set; }

        public int Captain_id { get; set; }
        public int Player2_id { get; set; }
        public int Player3_id { get; set; }
        public int Player4_id { get; set; }
        public int Player5_id { get; set; }

       public virtual ICollection<TeamCommunication> TeamCommunications { get; set; }

       public Team()
        {
           TeamCommunications = new List<TeamCommunication>();
        }
    }
}
