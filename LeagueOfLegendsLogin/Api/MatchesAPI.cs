using LeagueOfLegendsLogin.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsLogin.Api
{
    public class MatchesAPI : MainAPI
    {
        public MatchesAPI(string region) : base(region)
        {
        }

        public MatchlistDTO GetMatches(string accountId)
        {
            RestClient client = new RestClient($"https://{Region}.api.riotgames.com/lol/");
            var request = new RestRequest($"match/v4/matchlists/by-account/{accountId}?api_key={Key}", Method.GET);
            var response = client.Execute<MatchlistDTO>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<MatchlistDTO>(response.Content);
            }
            else
            {
                return null;
            }
        }
    }
}
