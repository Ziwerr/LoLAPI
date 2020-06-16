using RestSharp;
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
        public string Key { get; set; }
        public string Region { get; set; }


        public RiotAPI(string region)
        {
            Region = region;
            Key = "RGAPI-2d9d40e5-57a7-4792-8625-ec8cdebeda5a";
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
        protected string GetURIv2(string path)
        {
            return "https://" + Region + ".api.riotgames.com/lor/" + path + "?api_key=" + Key;

        }
    }
}
