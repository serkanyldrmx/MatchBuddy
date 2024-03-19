using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchBuddy.Entities
{
    public class PlayerTeam:IEntity
    {
        public int PlayerTeamId { get; set; }
        public Team Team { get; set; }
        public int TeamId { get; set; }
        public Player Player { get; set; }
        public int PlayerId { get; set; }
    }
}
