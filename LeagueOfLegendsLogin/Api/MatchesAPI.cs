using LeagueOfLegendsLogin.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsLogin.Api
{
    public class MatchesAPI : RiotAPI
    {
        public MatchesAPI(string region) : base(region)
        {
        }
        public MatchlistDTO GetMatches(string accountId)
        {
            string path = "match/v4/matchlists/by-account/" + accountId;

            var response = GET(GetURI(path));

            string content = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<MatchlistDTO>(content);
            }
            else
            {
                return null;
            }
        }
    }
}
