using System.ComponentModel;

namespace LeagueOfLegendsLogin
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        string region;
        public string Region
        {
            get { return region; }
            set { region = value; Summoner.Reg=value; OnPropertyChanged("Region"); }
        }

        string summonerName;
        public string SummonerName
        {
            get { return summonerName; }
            set { summonerName = value; OnPropertyChanged("SummonerName"); }
        }
    }
}
