using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsLogin
{
    public class LeagueAPI : MainAPI
    {
        public LeagueAPI(string region) : base(region)
        {
        }
        public List<LeagueEntryDTO> GetEntrys(string summonerId)
        {
            RestClient client = new RestClient($"https://{Region}.api.riotgames.com/lol/");
            var request = new RestRequest($"league/v4/entries/by-summoner/{summonerId}?api_key={Key}", Method.GET);
            var response = client.Execute<List<LeagueEntryDTO>>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<List<LeagueEntryDTO>>(response.Content);
            }
            else
            {
                return null;
            }
        }
    }
}
