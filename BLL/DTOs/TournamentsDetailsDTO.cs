using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class TournamentsDetailsDTO:TournamentDTO
    {
        public ICollection<ParticipantDTO> Participants { get; set; }
        public ICollection<MatchDTO> Matches { get; set; }
        public ICollection<RankingDTO> Rankings { get; set; }
    }
}
