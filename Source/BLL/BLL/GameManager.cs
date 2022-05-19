using DAL;
using Entities;
using Org.BouncyCastle.Crypto.Agreement.JPake;

namespace BLL;

public class GameManager
{
    private TournamentSystemGenerator _tournamentSystemGenerator;
    private Tournament _tournament;


    private List<Round> _rounds = new();

    public IList<Round> AllRounds
    {
        get
        {
            if (_rounds.Count == 0) _rounds = GetSchedule();
            return _rounds.AsReadOnly();
        }
    }


    private IGameDB _gameDB;

    public GameManager(IGameDB passed, Tournament t)
    {
        _tournament = t;
        if (t.TournamentSystem == TournamentSystems.RoundRobin) _tournamentSystemGenerator = new RoundRobinGenerator(t);
        if (t.TournamentSystem == TournamentSystems.SingleElimination)
            _tournamentSystemGenerator = new SingleEliminationGenerator(t);
        _gameDB = passed;
    }


    public List<Round> GetSchedule()
    {
        _tournamentSystemGenerator.Initializer();
        return _tournamentSystemGenerator.CreteSchedule(null);
    }

    public void UpdatePlayerScore(Round r, Fight f, int scorePL1, int scorePl2)
    {
        //exceptions might be trown if player cannot be found
        var p1 = _rounds.Find(x => x.RoundNumber == r.RoundNumber).Fights.Find(y => y.id == f.id).Player1;
        var p2 = _rounds.Find(x => x.RoundNumber == r.RoundNumber).Fights.Find(y => y.id == f.id).Player2;

        p1.Score = scorePL1;
        p2.Score = scorePl2;
    }


    public void SaveGame()
    {
        //check if badminton rules are followed corectly
        foreach (var r in _rounds)
        foreach (var f in r.Fights)
            if (f.isB == false)
                //check if score is valid and if it is add points to the corresponding player
                if (!f.isValid_PointsIncrease())
                    throw new ArgumentException(
                        $"round {r.RoundNumber} - fight {f.Player1.Player.firstName} vs {f.Player2.Player.firstName} has not been finished correctly ");

        _gameDB.PushTournament(_tournament, _rounds);
        if (_tournament.TournamentSystem == TournamentSystems.SingleElimination)
            _tournamentSystemGenerator.CreteSchedule(_rounds);
    }

    public GameResultData GetTournamentResults()
    {
        return _gameDB.GetGameResults(_tournament);
    }


    // required because single elimination tournaments cant generate the whole schedule at once and need   
    // void SingleEliminationRoundUpdater()
    // {    
    //     bool roundFinished = false;
    //     foreach (var f in _rounds[_rounds.Count - 1].Fights)
    //     {   //check if the round has been finished before (a.k.a if you are returning and changing results to an old round)
    //         if(f.Player1.Score ==0 || f.Player2.Score ==0)
    //         {
    //             roundFinished = true;
    //         }
    //     }
    //
    //     if (roundFinished)
    //     {
    //        
    //     }
    // }
}