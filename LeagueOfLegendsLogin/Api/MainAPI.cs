namespace LeagueOfLegendsLogin
{
    public class MainAPI
    {
        public string Key { get; set; }
        public string Region { get; set; }
        public MainAPI(string region)
        {
            Region = region;
            Key = "RGAPI-6086db84-d3a2-461b-95f9-70d7e314f070";
        }
    }
}
