namespace Entities;

public abstract class TournamentInPlay : Tournament
{
    private protected int round { get; set; }
    protected List<GamePlayer> _players { get;  } = new(); //used by the initializer to prepare the players for CreteSchedule() 
    
    private List<Round> _rounds = new();

    public IList<Round> AllRounds
    {
        get
        {   
            if (_rounds.Count == 0) _rounds = CreteSchedule(null);
            return _rounds.AsReadOnly();
        }
    }
    
    
    

    public void Initializer()
    {
        for (var i = 0; i < base.Players.Count; i++)
            _players.Add(new GamePlayer() { id = i, Player = base.Players[i], Score = 0, isB = false });

        if (base.Players.Count % 2 == 1)
            _players.Add(new GamePlayer() { id = base.Players.Count, Player = null, Score = 0, isB = true });
    }


    protected abstract List<Round> CreteSchedule(List<Round> nu);
    



    public void UpdatePlayerScore(Round r, Fight f, int scorePL1, int scorePl2)
    {
        //exceptions might be trown if player cannot be found
        var p1 = _rounds.Find(x => x.RoundNumber == r.RoundNumber).Fights.Find(y => y.id == f.id).Player1;
        var p2 = _rounds.Find(x => x.RoundNumber == r.RoundNumber).Fights.Find(y => y.id == f.id).Player2;
        
        p1.Score = scorePL1;
        p2.Score = scorePl2;
    }


            //saveGame
            public void UpdateGame()
            {
                bool isValid = false;
                foreach (var r in _rounds)
                {
                    foreach (var f in r.Fights)
                    {
                        if (f.isB == false)
                            //check if score is valid and if it is add points to the corresponding player
                            if (!f.isValid_PointsIncrease())
                            {
                                throw new ArgumentException(
                                    $"round {r.RoundNumber} - fight {f.Player1.Player.firstName} vs {f.Player2.Player.firstName} has not been finished correctly ");
                            }
                            else
                            {
                                isValid = true;
                            }
                    }
                }

                if (isValid && base.TournamentSystem == TournamentSystems.SingleElimination) CreteSchedule(_rounds);
            }



}