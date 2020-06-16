using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Compilation;
using System.Windows;

namespace LeagueOfLegendsLogin
{
    public class SummonerAPI : RiotAPI
    {
        public SummonerAPI(string region) : base(region)
        {

        }
        public SummonerDTO GetSummonerByName(string SummonerName)
        {
            string path = "summoner/v4/summoners/by-name/" + SummonerName;

            var response = GET(GetURI(path));

            string content = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<SummonerDTO>(content);
            }
            else
            {
                return null;
            }
        }
        
    }
}
