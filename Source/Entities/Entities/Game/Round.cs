namespace Entities;

public struct Round
{
    public int RoundNumber { get; init; }
    public List<Fight> Fights { get; init; }
}