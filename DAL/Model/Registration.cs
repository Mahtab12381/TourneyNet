﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Registration
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        public string UserName { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }
        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        public virtual ICollection<FanPost> FanPost { get; set; }

       public Registration()
        {
            FanPost = new List<FanPost>();
        
        }

        public virtual ICollection<Fan> Fans { get; set; }

        //public Registration()
        //{
        //    Fans = new List<Fan>();
        //}


        public virtual ICollection<Organizer> Organizers { get; set; }

        //public Registration()
        //{
        //    Organizers = new List<Organizer>();
        //}

    }
}
