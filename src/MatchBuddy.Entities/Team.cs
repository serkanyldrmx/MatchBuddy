﻿using Core.Entities;

namespace MatchBuddy.Entities
{
    public class Team:IEntity
    {
        public  int TeamId { get; set; }
        public string TeamName { get; set; }
        public List<MatchTeam> MatchTeams { get; set; }
        public List<PlayerTeam> PlayerTeams { get; set; }
    }
}
