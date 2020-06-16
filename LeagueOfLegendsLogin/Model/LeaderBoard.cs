using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsLogin.Model
{
    public class LeaderBoard
    {
        public List<PlayerDTO> Players { get; set; }
    }
    public class PlayerDTO
    {
        public string Name { get; set; }
        public int Rank { get; set; }
    }
}
