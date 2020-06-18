using Newtonsoft.Json;
using RestSharp;
using RestSharp.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Compilation;
using System.Web.UI.WebControls;
using System.Windows;

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
            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<SummonerDTO>(response.Content);
            }
            return null;
        }
        
    }
}
