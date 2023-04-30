using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class FanPostDTO
    {
        public int FanPost_id { get; set; }
        public string PostContent { get; set; }
        public DateTime PostDate { get; set; }
    }
}
