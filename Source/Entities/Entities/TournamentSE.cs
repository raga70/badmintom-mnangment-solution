namespace Entities;

public class TournamentSE : TournamentInPlay
{
    public TournamentSE(Tournament t)
    {
        SportType = t.SportType;
        StartDate = t.StartDate;
        EndDate = t.EndDate;
        MinPlayers = t.MinPlayers;
        MaxPlayers = t.MaxPlayers;
        Location = t.Location;
        TournamentSystem = t.TournamentSystem;
        Tournamnet_id = t.Tournamnet_id;
        Description = t.Description;
        Gender = t.Gender;
        Players = t.Players;
    }


    private Round CreteFirstRound()
    {
        string errMsg = null;
        Initializer();
        var players = new List<GamePlayer>();
        players.AddRange(_players);
        if (!ArePlayersPowerOfTwo())
            errMsg =
                "The number of players is not power of 2 which will introduce  rotating skipping player (this may not be fare completion), if you wish you can still change the tournament type in the Manage panel ";

        var _isB = false;
        var fights = new List<Fight>();
        for (var i = 0; i < _players.Count / 2; i++)
        {
            if (players[players.Count - 1].isB || players[players.Count - 2].isB) _isB = true;
            else
                _isB = false;

            var f = new Fight
                { Player1 = players[players.Count - 2], Player2 = players[players.Count - 1], isB = _isB, id = i };
            players.RemoveAt(players.Count - 1);
            players.RemoveAt(players.Count - 1);
            fights.Add(f);
        }

        return new Round { Fights = fights, RoundNumber = 1, Errmsg = errMsg };
    }

    protected override List<Round> CreteSchedule(List<Round> rounds)
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
                if (f.Player1.isB)
                    players.Add(f.Player2);
                else if (f.Player2.isB)
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
                    if (players[players.Count - 1].isB || players[players.Count - 2].isB) _isB = true;
                    else
                        _isB = false;
                    var f = new Fight
                    {
                        Player1 = players[players.Count - 2], Player2 = players[players.Count - 1], isB = _isB, id = i
                    };
                    players.RemoveAt(players.Count - 1);
                    players.RemoveAt(players.Count - 1);
                    fights.Add(f);
                }

                rounds.Add(new Round { Fights = fights, RoundNumber = rounds.Count + 1, Errmsg = errMsg });
            }
        }

        return rounds;
    }

    private bool ArePlayersPowerOfTwo()
    {
        var a = (int)Math.Ceiling(Math.Log(Players.Count) / Math.Log(2)) ==
                (int)Math.Floor(Math.Log(Players.Count) / Math.Log(2));
        return a;
    }
}