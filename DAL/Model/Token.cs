using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class Token
    {
        [Key]
        public int token_id { get; set; }
        [Required]
        public string Token_key { get; set; }
        [Required]
        public DateTime Created_at { get; set; }
        public DateTime? deleted_at { get; set; }

        [Required]
        public int User_id { get; set; }

    }
}
