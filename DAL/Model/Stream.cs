using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Stream
    {
        [Key]
        public int Stream_id { get; set; }
        [Required]
        public int Event_id { get; set; }
        [Required]
        public string Stream_link { get; set; }
        public string Stream_description { get; set; }
    }
}
