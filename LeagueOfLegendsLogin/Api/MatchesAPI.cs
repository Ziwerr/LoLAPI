using LeagueOfLegendsLogin.Models;
using RestSharp;

namespace LeagueOfLegendsLogin.Api
{
    public class MatchesAPI : MainAPI
    {
        private static readonly string CHAMPION_URL = "http://ddragon.leagueoflegends.com/cdn/10.12.1/data/en_US/champion.json";
        public MatchesAPI(string region) : base(region)
        {
        }

        public MatchlistDTO GetMatches(string accountId)
        {
            RestClient client = new RestClient($"https://{Region}.api.riotgames.com/lol/");
            var request = new RestRequest($"match/v4/matchlists/by-account/{accountId}?api_key={Key}", Method.GET);
            var response = client.Execute<MatchlistDTO>(request);
            if (response.IsSuccessful)
            {
                var champion = ChampionAPI.GetChampions();
                return response.Data;
            }
            else
            {
                return null;
            }
        }
    }
}
