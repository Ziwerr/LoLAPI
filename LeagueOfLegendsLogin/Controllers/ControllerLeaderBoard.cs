using LeagueOfLegendsLogin.Api;
using LeagueOfLegendsLogin.Models;
using System.Collections.Generic;
using System.Linq;

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
