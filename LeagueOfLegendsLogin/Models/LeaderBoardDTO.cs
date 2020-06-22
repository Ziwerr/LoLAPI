using System.Collections.Generic;

namespace LeagueOfLegendsLogin.Models
{
    public class LeaderBoardDTO
    {
        public List<PlayerDTO> Players { get; set; }
    }
    public class PlayerDTO
    {
        public string Name { get; set; }
        private int _rank { get; set; }
        public int Rank
        {
            get
            {
                return _rank+1;
            }
            set
            {
                _rank = value;
            }
        }
    }
}
