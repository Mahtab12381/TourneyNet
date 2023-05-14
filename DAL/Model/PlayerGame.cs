using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class PlayerGame
    {

        [Key]
        public int Player_Game_Id { get; set; }
        [Required]
        public string Game_Name { get; set; }

        public string Player_Skill { get; set; }

        [ForeignKey("Player")]
        public int Player_Id { get; set; }
        public virtual Player Player { get; set; }
    }
}
