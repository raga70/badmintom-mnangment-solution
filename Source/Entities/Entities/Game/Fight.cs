namespace Entities;

public struct Fight
{
    public int id { get; init; }
    public GamePlayer Player1 { get; init; }
    public GamePlayer Player2 { get; init; }
    public bool isB { get; init; }
}