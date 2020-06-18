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
    public class MainAPI
    {
        public string Key { get; set; }
        public string Region { get; set; }
        public MainAPI(string region)
        {
            Region = region;
            Key = "RGAPI-493a9309-54bf-4e34-8156-15d4550c27da";
        }
    }
}
