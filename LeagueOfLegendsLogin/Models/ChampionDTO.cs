namespace LeagueOfLegendsLogin.Models
{
    public class ChampionDTO
    {
        public Data Champions{ get; set; }
    }
    public class Data
    {
        public int Key { get; set; }
        public string Name { get; set; }
    }
}
