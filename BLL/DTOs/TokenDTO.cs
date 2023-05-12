using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class TokenDTO
    {
        public int token_id { get; set; }
   
        public string Token_key { get; set; }
  
        public DateTime Created_at { get; set; }
        public DateTime? deleted_at { get; set; }
        public string User_id { get; set; }
        public string Type { get; set; }

        public int reg_id { get; set; }

    }
}
