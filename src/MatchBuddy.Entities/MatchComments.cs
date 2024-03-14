using Core.Entities;

namespace MatchBuddy.Entities
{
    public class MatchComments:IEntity
    {
        public int CommentsId { get; set; }
        public Player Player { get; set; }
        public int UserId { get; set; }
        public Match Match { get; set; }
        public int MatchId { get; set; }
        //public string PlayerName { get; set; }
        
    }
}
