using DAL;
using Entities;
using Org.BouncyCastle.Crypto.Agreement.JPake;

namespace BLL;

public class GameManager
{
    ITournamentSystemManager _tournamentSystemManager;
    private Tournament _tournament;


    private List<Round> _rounds = new List<Round>();

    public IList<Round> AllRounds
    {
        get
        {
            if (_rounds.Count == 0) _rounds = GetSchedule();
            return _rounds.AsReadOnly();
        }
    }


    IGameDB _gameDB;
    public GameManager(IGameDB passed,Tournament t)
    {
        _tournament = t;
        if (t.TournamentSystem == TournamentSystems.RoundRobin) _tournamentSystemManager = new RoundRobin(t);
        _gameDB = passed;
    }


    public List<Round> GetSchedule()
    {
        _tournamentSystemManager.Initializer();
        return _tournamentSystemManager.CreteSchedule();
    }

    public void UpdatePlayerScore(Round r,Fight f, int scorePL1, int scorePl2)
    { 
        //exceptions might be trown if player cannot be found
        var p1 =   _rounds.Find(x => x.RoundNumber == r.RoundNumber).Fights.Find(x=>x.id==f.id).Player1;
        var p2 =   _rounds.Find(x => x.RoundNumber == r.RoundNumber).Fights.Find(x => x.id == f.id).Player2;

        p1.Score = scorePL1;
        p2.Score = scorePl2;
        
    }

    public void SaveGame()
    {
        //check if badminton rules are followed corectly
        foreach (var r in _rounds)
        {
            foreach (var f in r.Fights)
            {
                if (f.Player1.Score != 21 && f.Player2.Score != 21 )
                {
                    if (f.Player1.Score - f.Player2.Score != 2 && f.Player1.Score - f.Player2.Score != -2)
                    {
                        if (f.Player1.Score == 30 && f.Player2.Score == 29 ||
                            f.Player2.Score == 30 && f.Player1.Score == 29)
                        {
                            throw new ArgumentException(
                                $"round {r.RoundNumber} - fight {f.Player1.Player.firstName} vs {f.Player2.Player.firstName} has not been finished correctly ");
                        }
                        throw new ArgumentException(
                            $"round {r.RoundNumber} - fight {f.Player1.Player.firstName} vs {f.Player2.Player.firstName} has not been finished correctly ");
                    }
                    throw new ArgumentException(
                        $"round {r.RoundNumber} - fight {f.Player1.Player.firstName} vs {f.Player2.Player.firstName} has not been finished correctly ");
                }
                
                else
                {
                    if(f.Player1.Score>f.Player2.Score)
                        f.Player1.Player.IncresePoints();
                    else
                        f.Player2.Player.IncresePoints(); 
                  
                }
            }   
        }
        _gameDB.PushTournament(_tournament, _rounds);
    }
    
    public GameResultData GetTournamentResults()
    {
        return _gameDB.GetGameResults(_tournament);
    }
    
}