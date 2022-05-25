namespace Entities;

public record GamePlayer
{
    public int id { get; init; }
    public User Player { get; init; }
    public int Score { get; set; }
    public bool isB { get; init; }


    public GamePlayer()
    {
    }


    //new object invoction
    public GamePlayer(GamePlayer passed)
    {
        id = passed.id;
        Player = passed.Player;
        Score = passed.Score;
        isB = passed.isB;
    }
}