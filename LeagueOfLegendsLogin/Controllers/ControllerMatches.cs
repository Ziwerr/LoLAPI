using LeagueOfLegendsLogin.Api;
using LeagueOfLegendsLogin.Models;
using System.Collections.Generic;

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
    