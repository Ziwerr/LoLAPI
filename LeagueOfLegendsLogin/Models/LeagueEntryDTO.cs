﻿namespace LeagueOfLegendsLogin.Models
{
    public class LeagueEntryDTO
    {
        public string Tier { get; set; }
        public string Rank { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public string QueueType { get; set; }
    }
}
