using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueOfLegendsLogin.Models
{
    public class Champion
    {
        public Data Champions{ get; set; }
    }
    public class Data
    {
        public int Key { get; set; }
        public string Name { get; set; }
    }
}
