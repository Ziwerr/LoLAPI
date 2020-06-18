using LeagueOfLegendsLogin.Api;
using LeagueOfLegendsLogin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsLogin
{
    public class ControllerLeaderBoard
    {
        public List<PlayerDTO> GetLeaderBoards()
        {
            LeaderBoardAPI leaderBoardAPI = new LeaderBoardAPI();
            var board = leaderBoardAPI.GetPlayers().Players.Take(100).ToList();
            return board;
        }
    }
}
