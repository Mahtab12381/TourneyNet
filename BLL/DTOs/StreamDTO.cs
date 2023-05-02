using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class StreamDTO
    {
       
        public int Stream_id { get; set; }
        
        public int Event_id { get; set; }
        
        public string Stream_link { get; set; }
        public string Stream_description { get; set; }
    }
}
