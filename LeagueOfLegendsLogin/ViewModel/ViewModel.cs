using System.ComponentModel;

namespace LeagueOfLegendsLogin
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        string _region;
        public string Region
        {
            get { return _region; }
            set { _region = value; Summoner.Reg=value; }
        }
        public string SummonerName { get;set; }
    }
}
