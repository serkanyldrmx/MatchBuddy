﻿using Core.Entities;

namespace MatchBuddy.Entities
{
    public class Stadium:IEntity
    {
        public int StadiumId { get; set; }
        public string StadiumName { get; set; }
        public List<Match> Matches { get; set; }
    }
}