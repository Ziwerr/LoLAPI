using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsLogin
{
    public class Controller
    {
        public bool GetSummoner(string summonerName)
        {
            SummonerAPI summonerAPI = new SummonerAPI(Summoner.Reg);
            var summoner = summonerAPI.GetSummonerByName(summonerName);
            Summoner.Sum = summoner;
            return summoner != null;
        }
    }
}
