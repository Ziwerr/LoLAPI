using LeagueOfLegendsLogin.Models;
using RestSharp;

namespace LeagueOfLegendsLogin.Api
{
    public class LeaderBoardAPI
    {
        public string Region { get; set; } = "europe";
        MainAPI mainAPI = new MainAPI(Summoner.Reg);
        public LeaderBoardDTO GetPlayers()
        {
            RestClient client = new RestClient($"https://{Region}.api.riotgames.com/lor/");
            var request = new RestRequest($"ranked/v1/leaderboards?api_key={mainAPI.Key}", Method.GET);
            var response = client.Execute<LeaderBoardDTO>(request);
            if (response.IsSuccessful)
            {
                return response.Data;
            }
            else
            {
                return null;
            }
        }
    }
}
