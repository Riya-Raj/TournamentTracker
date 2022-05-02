using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// The unique identifier for the tournament
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents the tournament name
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Represents the entry fee required to participate in the tournament
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Represents the list of the teams entered in the tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// represents the prizes decided for this tournament
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// Represents the rounds decided and the matchup teams decided for each round
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
