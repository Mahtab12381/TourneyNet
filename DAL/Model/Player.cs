using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Player
    {
        [Key]
        public int player_Id { get; set; }
        public string gender { get; set; }
        public string nationality { get; set; }
        public int age { get; set; }

        public virtual ICollection<PlayerGame> PlayerGames { get; set; }

        //public Player()
        //{
        //   PlayerGames = new List<PlayerGame>();
        //}
    }
}
