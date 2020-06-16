
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsLogin
{
    public class ViewModelSummoner
    {
        public string SummonerName { get; set; }
        public string Icon { get; set; }
        public long Level { get; set; }
        public string Tier { get; set; }
        public string Rank { get; set; }
        public string RankedIcon { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }

        public ViewModelSummoner(string summonerName, int icon, long level, string tier, string rank, int wins, int losses)
        {
            SummonerName = summonerName;
            Icon = "http://opgg-static.akamaized.net/images/profile_icons/profileIcon" + icon + ".jpg";
            Level = level;
            Tier = tier;
            Rank = rank;
            RankedIcon = "/LeagueOfLegendsLogin;component/Images/Icons_Rank/" + tier + ".png";
            Wins = wins;
            Losses = losses;
        }

    }
}
