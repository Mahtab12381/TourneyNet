using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        public virtual ICollection<Event> Events { get; set; }

        //public Organizer()
        //{
        //    Events = new List<Event>();
        //}

        [ForeignKey("Registration")]
        public int Organizer_by { get; set; }
        public virtual Registration Registration { get; set; }
    }
}
