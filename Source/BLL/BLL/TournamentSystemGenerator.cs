namespace BLL;

using Entities;

public abstract class TournamentSystemGenerator
{
    protected Tournament _tournament;

    protected int round { get; set; }
    protected List<GamePlayer> _players = new();


    public TournamentSystemGenerator(Tournament t)
    {
        _tournament = t;
    }


    public void Initializer()
    {
        for (var i = 0; i < _tournament.Players.Count; i++)
            _players.Add(new GamePlayer() { id = i, Player = _tournament.Players[i], Score = 0, isB = false });

        if (_tournament.Players.Count % 2 == 1)
            _players.Add(new GamePlayer() { id = _tournament.Players.Count, Player = null, Score = 0, isB = true });
    }


    public abstract List<Round> CreteSchedule(List<Round> rounds);
}