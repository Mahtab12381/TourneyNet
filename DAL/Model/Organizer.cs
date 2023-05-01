using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Organizer
    {
        [Key]
        public int Organizer_Id { get; set; }
        [Required]
        public string Organizer_Description { get; set; }
    }
}
