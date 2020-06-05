using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LeagueOfLegendsLogin
{
    public class SummonerDTO
    {
        public int ProfileIconId { get; set; }
        public string Name { get; set; }
        public long SummonerLevel { get; set; }
        public string Id { get; set; }
    }
}
