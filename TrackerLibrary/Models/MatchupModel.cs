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
        /// The Id from the database that will be used to look up the winner
        /// </summary>
        public int WinnerId { get; set; }
        /// <summary>
        /// Represnt the winner of this matchup
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Represents the round for which its a matchup
        /// </summary>
        public int MatchupRound { get; set; }
        public string DisplayName 
        { 
            get
            {
                string output = "";

                foreach (MatchupEntryModel me in Entries)
                {
                    if (me.TeamCompeting != null)
                    {
                        if (output.Length == 0)
                        {
                            output = me.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output += $" vs. { me.TeamCompeting.TeamName }";
                        } 
                    }
                    else
                    {
                        output = "Matchup not yet determined";
                        break;
                    }
                }

                return output;
            } 
        }
    }
}
