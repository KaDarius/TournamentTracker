using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one match in the tourney
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// Set of teams that were involved in this match
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; }
        /// <summary>
        /// winner name is going to come from class TeamModel
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Which round this match is a part of.s
        /// </summary>

        public int MatchupRound { get; set; }
    }
}
