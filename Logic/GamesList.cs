// public class GamesListDB
// {
//     private List<GameInfoRequest> gamesListDB = new();
//     public LMLogger logger;
//     public GamesListDB(LMLogger logger)
//     {
//         this.logger = logger;
//     }

//     public  int getGamesCount()
//     {
//         return gamesListDB.Count;
//     }

//     public  bool add(GameInfoRequest req)
//     {
//         logger.Log($"Adding game {req.GameName} to the list...");
//         if (req.GameName == null || req.GameExe == null || req.UserName == null || req.Ip == null)
//         {            
//             throw new Exception("Invalid game info.");            
//         }
//         var gameExist = gamesListDB.Count(x => x.GameName == req.GameName) > 0;
        
//         if (gameExist)
//         {
//             logger.Log($"Game {req.GameName} already exists in the games list.");  
//             return false;      
//         }
        
//         logger.Log($"Game {req.GameName} added to the list.");
//         gamesListDB.Add(req);
//         return true;
//     }
// }
