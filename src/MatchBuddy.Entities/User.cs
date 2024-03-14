using Core.Entities;

namespace MatchBuddy.Entities
{
    public class User:IEntity
    {
        public int UserId { get; set; }
        public Player Player { get; set; }
        public int PlayerId { get; set; }
        public Match Match { get; set; }
        public int MatchId { get; set; }
        //public string PlayerName { get; set; }
        
    }
}
