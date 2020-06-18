using LeagueOfLegendsLogin.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsLogin.Api
{
    public class LeaderBoardAPI
    {
        public string Region { get; set; } = "europe";
        public string Key { get; set; } = "RGAPI-493a9309-54bf-4e34-8156-15d4550c27da";
        public LeaderBoard GetPlayers()
        {
            RestClient client = new RestClient($"https://{Region}.api.riotgames.com/lor/");
            var request = new RestRequest($"ranked/v1/leaderboards?api_key={Key}", Method.GET);
            var response = client.Execute<LeaderBoard>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<LeaderBoard>(response.Content);
            }
            else
            {
                return null;
            }
        }
    }
}
