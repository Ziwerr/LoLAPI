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
        public LeagueEntryDTO GetEntry(SummonerDTO summoner)
        {
            LeagueAPI leagueAPI = new LeagueAPI(Summoner.Reg);
            var entrys = leagueAPI.GetEntrys(summoner.Id)
                         .Where(x => x.QueueType.Equals("RANKED_SOLO_5x5")).FirstOrDefault();
            return entrys;
        }

    }
}
