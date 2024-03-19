using Core.Entities;

namespace MatchBuddy.Entities
{
    public class MatchComment 
    {
        public int CommentsId { get; set; }
        public string? Comment { get; set; }
        public Player Player { get; set; }
        public int playerId { get; set; }
        public int MatchId { get; set; }
        public Match Match { get; set; }
    }
}
