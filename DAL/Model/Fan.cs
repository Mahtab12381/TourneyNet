using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Fan
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Bio { get; set; }
        [Required]
        public string ContactInformation { get; set; }

        [ForeignKey("Registration")]
        public int Fan_Id { get; set; }
        public virtual Registration Registration { get; set; }

    }
}
