using Core.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace MatchBuddy.Entities
{
    public class Message:IEntity
    {
        public int MessageId { get; set; }
        public string MatchMessage { get; set; }
        public DateTime SendingDate { get; set; }
        public byte Status { get; set; }
        public int SendPlayerId { get; set; }
        public int RecipientPlayerId { get; set; }
    }
}
