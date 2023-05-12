using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class SocialMediaSharingDTO
    {
        public int share_id { get; set; }
        public int event_id { get; set; }

        public DateTime share_date { get; set; }

        public string platform { get; set; }

        public string share_description { get; set; }
    }
}
