using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class TeamDTO
    {
        
        public int Team_id { get; set; }
        
        public string Team_name { get; set; }
       
        public string Team_logo { get; set; }

        public int Captain_id { get; set; }
        public int Player2_id { get; set; }
        public int Player3_id { get; set; }
        public int Player4_id { get; set; }
        public int Player5_id { get; set; }

        

    }
}
