using FastEndpoints;
using Microsoft.AspNetCore.Http.HttpResults;

public class RegisterGame : Endpoint<GameInfoRequest,GameInfoResponse>
{
    private IData _data;
    public RegisterGame(IData data)
    {
        _data = data;
    }

    public override void Configure()
    {
        Post("/Games/RegisterGame");
        AllowAnonymous();
    }

    public override async Task HandleAsync(GameInfoRequest req, CancellationToken ct)
    {                 
        var game = new Game
        {
            GameName = req.GameName,
            GameExe = req.GameExe,
            UserName = req.UserName,
            Ip = req.Ip
        };       

        if (_data.GetGameByName(game.GameName) != null)
        {            
            AddError("Game already exists");
            ThrowIfAnyErrors();            
        }
        _data.AddGame(game);
        
        int gamesCount = _data.GetGameCount();
        
        await SendAsync(new GameInfoResponse
        {
            GameName = req.GameName,
            GameExe = req.GameExe,
            UserName = req.UserName,
            Ip = req.Ip,
            Count = gamesCount
        });
    }
}


