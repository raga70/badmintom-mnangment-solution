namespace Entities;

public class TournamentSE : TournamentInPlay
{
    
    
    
    public TournamentSE(Tournament t):base()
    {
        base.SportType = t.SportType;
        base.StartDate = t.StartDate;
        base.EndDate = t.EndDate;
        base.MinPlayers = t.MinPlayers;
        base.MaxPlayers = t.MaxPlayers;
        base.Location = t.Location;
        base.TournamentSystem = t.TournamentSystem;
        base.Tournamnet_id = t.Tournamnet_id;
        base.Description = t.Description;
        base.Gender = t.Gender;
        base.Players = t.Players;
    }
    
    
    
    
    
    private Round CreteFirstRound()
    {string errMsg = null;
        Initializer();
        var players = new List<GamePlayer>();
        players.AddRange(_players);
        if (!ArePlayersPowerOfTwo())  errMsg = "The number of players is not power of 2 which will introduce  rotating skipping player (this may not be fare completion), if you wish you can still change the tournament type in the Manage panel ";

        var _isB = false;
        var fights = new List<Fight>();
        for (var i = 0; i < _players.Count / 2; i++)
        {
            if (players[players.Count - 1].isB == true || players[players.Count - 2].isB == true) _isB = true;
            else
                _isB = false;

            var f = new Fight()
                { Player1 = players[players.Count - 2], Player2 = players[players.Count - 1], isB = _isB, id = i };
            players.RemoveAt(players.Count - 1);
            players.RemoveAt(players.Count - 1);
            fights.Add(f);
        }

        return new Round() { Fights = fights, RoundNumber = 1,Errmsg = errMsg};
    }

    protected override  List<Round> CreteSchedule(List<Round> rounds)
    {
        string errMsg = null;
        if (TournamentSystem != TournamentSystems.SingleElimination)
            throw new ArgumentException("Tournament type from base class doesnt match schedule generator");
        if (rounds is null || rounds.Count == 0)
        {
            rounds = new List<Round>();
            rounds.Add(CreteFirstRound());

        }
        else
        {
            //if there is only one player dont generate a new round 

            var players = new List<GamePlayer>();

            foreach (var f in rounds[rounds.Count - 1].Fights)
                //bogus player fight auto win 
                if (f.Player1.isB == true)
                    players.Add(f.Player2);
                else if (f.Player2.isB == true)
                    players.Add(f.Player1);

                else if (f.Player1.Score > f.Player2.Score)
                    players.Add(f.Player1);
                else
                    players.Add(f.Player2);

            if (players.Count > 1)
            {
                var _isB = false;
                var fights = new List<Fight>();
                for (var i = 0; i < players.Count / 2; i++)
                {
                    if (players[players.Count - 1].isB == true || players[players.Count - 2].isB == true) _isB = true;
                    else
                        _isB = false;
                    var f = new Fight()
                    {
                        Player1 = players[players.Count - 2], Player2 = players[players.Count - 1], isB = _isB, id = i
                    };
                    players.RemoveAt(players.Count - 1);
                    players.RemoveAt(players.Count - 1);
                    fights.Add(f);
                }

                rounds.Add(new Round() { Fights = fights, RoundNumber = rounds.Count + 1,Errmsg = errMsg});
            }
        }

        return rounds;
    }
    
    bool ArePlayersPowerOfTwo()
    {
 
        
 
        bool a = (int)(Math.Ceiling((Math.Log(Players.Count) /
                                   Math.Log(2)))) ==
               (int)(Math.Floor(((Math.Log(Players.Count) /
                                  Math.Log(2)))));
        return a;
    }
    
    
    
}