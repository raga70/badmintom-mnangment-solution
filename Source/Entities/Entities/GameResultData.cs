namespace Entities;

public record GameResultData
{
    public Tournament tournament { get;init; }
    public List<fightData> fightsData { get;init; }

}


public struct fightData
{
    public string playerFirstName;
    public string playerLastName;
    public string fightScore;
    public string oponentFirstName;
    public string oponentLastName;

}