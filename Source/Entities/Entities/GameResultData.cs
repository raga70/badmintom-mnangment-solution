namespace Entities;

public class GameResultData
{
    public Tournament tournament { get; init; }
    public List<fightData> fightsData { get; init; }

    public int playerPoints { get; init; }
}

public struct fightData
{
    public string playerFirstName;
    public string playerLastName;
    public string fightScore;
    public string oponentFirstName;
    public string oponentLastName;
}