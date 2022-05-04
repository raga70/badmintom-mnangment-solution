namespace Entities;

public struct GamePlayer
{
    public int id { get; init; }
    public User Player { get; init; }
    public int Score { get; set; }
    public bool isB{get; init; }
}