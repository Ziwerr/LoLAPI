using LeagueOfLegendsLogin.Models;
using RestSharp;

namespace LeagueOfLegendsLogin.Api
{
    public class LeaderBoardAPI
    {
        public string Region { get; set; } = "europe";
        public string Key { get; set; } = "RGAPI-6086db84-d3a2-461b-95f9-70d7e314f070";
        public LeaderBoard GetPlayers()
        {
            RestClient client = new RestClient($"https://{Region}.api.riotgames.com/lor/");
            var request = new RestRequest($"ranked/v1/leaderboards?api_key={Key}", Method.GET);
            var response = client.Execute<LeaderBoard>(request);
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
