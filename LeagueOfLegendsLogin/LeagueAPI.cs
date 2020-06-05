using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsLogin
{
    public class LeagueAPI : RiotAPI
    {
        public LeagueAPI(string region) : base(region)
        {
        }

        public List<LeagueEntryDTO> GetEntrys(string summonerId)
        {
            string path = "league/v4/entries/by-summoner/" + summonerId;

            var response = GET(GetURI(path));

            string content = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<List<LeagueEntryDTO>>(content);
            }
            else
            {
                return null;
            }
        }
    }
}
