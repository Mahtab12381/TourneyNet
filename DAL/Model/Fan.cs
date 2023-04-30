using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Fan
    {
        [Key]
        public int Id { get; set; }

        public string Bio { get; set; }

        public string ContactInformation { get; set; }

    }
}
