using Core.Entities;

namespace MatchBuddy.Entities
{
    public class MatchComment:IEntity
    {
        public int CommentsId { get; set; }
        public Player Player { get; set; }
        public int playerId { get; set; }
        public Match Match { get; set; }
        public int MatchId { get; set; }
        //public string PlayerName { get; set; }
        
    }
}
