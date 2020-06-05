using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsLogin
{
    public class ViewModelSummoner
    {
        public string SummonerName { get; private set; }
        public string Icon { get; private set; }
        public long Level { get; private set; }
        public string Tier { get; private set; }
        public string Rank { get; private set; }
        public string RankedIcon { get; private set; }
        public int Wins { get; private set; }
        public int Losses { get; private set; }
        public ViewModelSummoner(string summonerName, int icon, long level, string tier, string rank, int wins, int losses)
        {
            SummonerName = summonerName;
            Icon = "http://opgg-static.akamaized.net/images/profile_icons/profileIcon" + icon + ".jpg";
            Level = level;
            Tier = tier;
            Rank = rank;
            RankedIcon = "LeagueOfLegendsLogin;component/Images/Icons_Rank/Icon_" + tier + ".png";
            Wins = wins;
            Losses = losses;
        }

    }
}
