using LeagueOfLegendsLogin.Models;
using RestSharp;

namespace LeagueOfLegendsLogin
{
    public class SummonerAPI : MainAPI
    {
        public SummonerAPI(string region) : base(region)
        {

        }
        public SummonerDTO GetSummonerByName(string SummonerName)
        {
            RestClient client = new RestClient($"https://{Region}.api.riotgames.com/lol/");
            var request = new RestRequest($"summoner/v4/summoners/by-name/{SummonerName}?api_key={Key}", Method.GET);
            var response = client.Execute<SummonerDTO>(request);
            if(response.IsSuccessful)
            {
                return response.Data;
            }
            return null;
        }
        
    }
}
