namespace LeagueOfLegendsLogin
{
    public class MainAPI
    {
        public string Key { get; set; }
        public string Region { get; set; }
        public MainAPI(string region)
        {
            Region = region;
            Key = "RGAPI-8ae59e14-6f06-4c70-9ec5-4d63945d0fdb";
        }
    }
}
