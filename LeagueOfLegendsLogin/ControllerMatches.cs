using LeagueOfLegendsLogin.Api;
using LeagueOfLegendsLogin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsLogin
{
    public class ControllerMatches
    {
        public List<MatchRefernceDto> GetMatches()
        {
            MatchesAPI matchesAPI = new MatchesAPI(Summoner.Reg);
            var matches = matchesAPI.GetMatches(Summoner.Sum.AccountId).Matches;
            return matches;
        }
    }
}
