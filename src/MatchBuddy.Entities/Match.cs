using Core.Entities;

namespace MatchBuddy.Entities
{
    public class Match:IEntity
    {
        public int MatchId { get; set; }
        public string? MatchName { get; set; }
        public DateTime MatchDate { get; set; }
        public int UserCount { get; set; }
        public string Description { get; set; }
        public byte IsActive { get; set; }
        public int StadiumId { get; set; }
        public int MatchTeamId { get; set; }
        public Stadium Stadium { get; set; }
        public List<MatchTeam> matchTeams { get; set; }
        public List<MatchComments> MatchComments { get; set; }

    }
}
