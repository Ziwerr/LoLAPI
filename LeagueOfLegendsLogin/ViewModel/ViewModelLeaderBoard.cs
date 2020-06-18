using LeagueOfLegendsLogin.Models;
using System.Collections.Generic;

namespace LeagueOfLegendsLogin
{
    public class ViewModelLeaderBoard
    {
        ControllerLeaderBoard controllerLeaderBoard = new ControllerLeaderBoard();
        public List<PlayerDTO> LeaderBoards
        { get
            {
                return controllerLeaderBoard.GetLeaderBoards();
            } 
        }
    }
}
