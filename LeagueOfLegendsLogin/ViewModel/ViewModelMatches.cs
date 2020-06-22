using LeagueOfLegendsLogin.Models;
using System.Collections.Generic;

namespace LeagueOfLegendsLogin
{ 
    public class ViewModelMatches
    {
        ControllerMatches controllerMatches = new ControllerMatches();
        public List<MatchRefernceDto> Matches
        {
            get
            {
                return controllerMatches.GetMatches();
            }
        }
    }
}
