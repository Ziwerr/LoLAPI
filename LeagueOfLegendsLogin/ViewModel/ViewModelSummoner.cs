
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsLogin
{
    public class ViewModelSummoner
    {
        Controller controller = new Controller();

        public LeagueEntryDTO League
        {
            get
            {
                return controller.GetEntry(Summoner.Sum);
            }
        }
        public string SummonerName
        {
            get
            {
                return Summoner.Sum.Name;
            }
        }
        public string Icon
        {
            get
            {
                return "http://opgg-static.akamaized.net/images/profile_icons/profileIcon" + Summoner.Sum.ProfileIconId + ".jpg";
            }
        }
        public long Level
        {
            get
            {
                return Summoner.Sum.SummonerLevel;
            }
        }
        public string Tier
        {
            get
            {
                return League.Tier;
            }
        }
        public string Rank
        {
            get
            {
                return League.Rank;
            }
        }
        public string RankedIcon
        {
            get
            {
                return "/LeagueOfLegendsLogin;component/Images/Icons_Rank/" + League.Tier + ".png";
            }
        }
        public int Wins
        {
            get
            {
                return League.Wins;
            }
        }
        public int Losses
        {
            get
            {
                return League.Losses;
            }
        }
    }
}
