using LeagueOfLegendsLogin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
