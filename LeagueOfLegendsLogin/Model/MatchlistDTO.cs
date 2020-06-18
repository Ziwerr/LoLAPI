using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsLogin.Model
{
    public class MatchlistDTO
    {
        public List<MatchRefernceDto> Matches { get; set; }
    }
    public class MatchRefernceDto
    {
        public string Role { get; set; }
        public int Season { get; set; }
        public string Lane{ get; set; }
        public long Timestamp { get; set; }
        public int Champion { get; set; }
        public int Queue { get; set; }
    }
}
