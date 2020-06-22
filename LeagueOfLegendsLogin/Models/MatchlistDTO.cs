using System.Collections.Generic;

namespace LeagueOfLegendsLogin.Models
{
    public class MatchlistDTO
    {
        public List<MatchRefernceDto> Matches { get; set; }
    }
    public class MatchRefernceDto
    {
        public string Role { get; set; }
        public int Season { get; set; }
        public string _lane { get; set; }
        public string Lane{ get { return char.ToUpper(_lane[0]) + _lane.Substring(1).ToLower(); } set { _lane = value; } }
        public long Timestamp { get; set; }
        public int Champion { get; set; }
        public int Queue { get; set; }
    }
}
