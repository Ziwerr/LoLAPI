using LeagueOfLegendsLogin.Models;
using RestSharp;
using System.Collections.Generic;

namespace LeagueOfLegendsLogin.Api
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
