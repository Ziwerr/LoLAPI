using LeagueOfLegendsLogin.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsLogin
{
    public class ControllerSummoner
    {
        public object GetContextFromSummoner()
        {
            var summoner = Constans.Summoner;

            var entry = GetEntry(summoner);

            return new ViewModelSummoner(summoner.Name,summoner.ProfileIconId,summoner.SummonerLevel, entry.Tier,entry.Rank,entry.Wins,entry.Losses);
        }

        private LeagueEntryDTO GetEntry(SummonerDTO summoner)
        {
            LeagueAPI leagueAPI = new LeagueAPI(Constans.Reg);

            var entrys = leagueAPI.GetEntrys(summoner.Id)
                         .Where(x=>x.QueueType.Equals("RANKED_SOLO_5x5")).FirstOrDefault();

            return entrys ?? new LeagueEntryDTO();
        }

        public void OpenMain()
        {
            MainWindow profile = new MainWindow();
            profile.Show();
        }
    }
}
