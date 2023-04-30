using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Participants
    {
        [Key]
        public int participant_id { get; set; }
        public string team_name { get; set; }

        public string team_logo { get; set;}

    }
}
