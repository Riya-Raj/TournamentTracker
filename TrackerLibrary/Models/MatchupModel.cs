using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// The unique identifier for the matchup
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// represnets the entries/teams in a particular matchup
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Represnt the winner of this matchup
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Represents the round for which its a matchup
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
