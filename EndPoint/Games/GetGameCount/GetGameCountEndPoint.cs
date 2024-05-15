using FastEndpoints;
public class GetGamesCount : Endpoint<GamesListCount>
{
    private IData _data;
    public GetGamesCount(IData data)
    {
        _data = data;
    }
    public override void Configure()
    {
        Get("/Games/GamesListCount");
        AllowAnonymous();
    }

    public override async Task HandleAsync(GamesListCount req, CancellationToken ct)
    {        
        int gamesCount = _data.GetGameCount();
        await SendAsync(new GamesListCount
        {
            Count = gamesCount
        });
    }
}


