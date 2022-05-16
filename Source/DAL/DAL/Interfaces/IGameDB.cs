using Entities;

namespace DAL;

public interface IGameDB
{
    void PushTournament(Tournament t, List<Round> rounds);
    GameResultData GetGameResults(Tournament tt);
}