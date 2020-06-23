namespace LeagueOfLegendsLogin
{
    public class MainAPI
    {
        public string Key { get; set; }
        public string Region { get; set; }
        public MainAPI(string region)
        {
            Region = region;
            Key = "RGAPI-d879fdf0-282a-4bb2-a256-499ce4a37c77";
        }
    }
}
