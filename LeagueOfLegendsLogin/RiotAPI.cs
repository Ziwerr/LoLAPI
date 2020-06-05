using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsLogin
{
    public class RiotAPI
    {
        private string Key { get; set; }
        private string Region { get; set; }

        public RiotAPI(string region)
        {
            Region = region;
            Key = "RGAPI-fcecc703-d588-4f5d-a6d7-24a48518c932";
        }

        protected HttpResponseMessage GET(string URL)
        {
            using (HttpClient client = new HttpClient())
            {
                var result = client.GetAsync(URL);
                result.Wait();

                return result.Result;
            }
        }
        protected string GetURI(string path)
        {
            return "https://" + Region + ".api.riotgames.com/lol/" + path + "?api_key=" + Key;
        }
        
    }
}
