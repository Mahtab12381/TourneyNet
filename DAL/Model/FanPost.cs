using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class FanPost
    {
        [Key]
        public int FanPost_id { get; set; }
        public string PostContent { get; set; }
        public DateTime PostDate { get; set; }

        [ForeignKey("Registration")]
        public int Posted_by_Id { get; set; }
        public virtual Registration Registration { get; set; }
    }
}
