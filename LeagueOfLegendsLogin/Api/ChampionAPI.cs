﻿using LeagueOfLegendsLogin.Models;
using RestSharp;

namespace LeagueOfLegendsLogin.Api
{
    public class ChampionAPI
    {
        public static Champion GetChampions()
        {
            RestClient client = new RestClient("http://ddragon.leagueoflegends.com/cdn/9.18.1/data/en_US/champion.json");
            var request = new RestRequest(Method.GET);
            var response = client.Execute<Champion>(request);
            if(response.IsSuccessful)
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
