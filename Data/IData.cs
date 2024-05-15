public interface IData
{
    public void AddGame(Game game);
    public Game? GetGameByName(string gameName);
    // public void RemoveGame(GameInfoRequest game);
    // public void AddUser(UserRequest user);
    // public void RemoveUser(UserRequest user);
    // public List<GameInfoRequest> GetGames();
    // public List<UserRequest> GetUsers();
    // public GameInfoRequest GetGame(string gameName);
    // public UserRequest GetUser(string userName);
    public int GetGameCount();
    // public int GetUserCount();
    // public void ClearGames();
    // public void ClearUsers();
    // public void ClearAll();
}