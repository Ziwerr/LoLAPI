using LeagueOfLegendsLogin.Model;
using Newtonsoft.Json;
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
        public string Key { get; set; } = "RGAPI-25b5ba29-edd8-4b91-ada4-947ac0b2d4ab";
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
            return "https://" + Region + ".api.riotgames.com/lor/" + path + "?api_key=" + Key;
        }

        public LeaderBoard GetPlayers()
        {
            string path = "ranked/v1/leaderboards";
            var response = GET(GetURI(path));
            string content = response.Content.ReadAsStringAsync().Result;
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<LeaderBoard>(content);
            }
            else
            {
                return null;
            }
        }
    }
}
