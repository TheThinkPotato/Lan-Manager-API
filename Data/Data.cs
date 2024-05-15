public class Data: IData {
    
    private List<Game> games = new List<Game>();

    public void AddGame(Game game)
    {        
        games.Add(game);        
    }

    public int GetGameCount()
    {
        return games.Count;
    }

    public Game? GetGameByName(string gameName)
    {
        return games.Find(x => x.GameName == gameName);
    }
}
