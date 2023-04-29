using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class PlayerDTO
    {
        public int player_Id { get; set; }
        public string gender { get; set; }
        public string nationality { get; set; }
        public int age { get; set; }
    }
}
