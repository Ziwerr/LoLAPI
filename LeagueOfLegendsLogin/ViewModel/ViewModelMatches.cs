using LeagueOfLegendsLogin.Model;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
