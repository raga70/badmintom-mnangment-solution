namespace Entities;

public record Round
{
    public int RoundNumber { get; init; }
    public List<Fight> Fights { get; init; }
}