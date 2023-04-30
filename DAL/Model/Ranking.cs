using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Ranking
    {
        [Key]
        public int ranking_id { get; set; }
        public int rank { get; set; }
    }
}
