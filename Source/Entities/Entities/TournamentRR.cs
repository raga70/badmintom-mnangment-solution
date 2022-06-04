namespace Entities;

public class TournamentRR : TournamentInPlay
{
    public TournamentRR(Tournament t)
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

    //public override List<Round> CreteSchedule(List<Round> nu) => CreteSchedule();

    protected override List<Round> CreteSchedule(List<Round> nu)
    {
        Initializer();
        if (TournamentSystem != TournamentSystems.RoundRobin)
            throw new ArgumentException("Tournament type from base class doesnt match schedule generator");

        if (_players.Count() <= 1) return null;
        var rounds = new List<Round>();
        var athletes = new List<GamePlayer>();

        athletes.AddRange(_players);
        athletes.RemoveAt(0); // i will deal with the first player separately 
        //round
        for (var i = 0; i < _players.Count - 1; i++)
        {
            var r = new Round
            {
                RoundNumber = i + 1,
                Fights = new List<Fight>()
            };
            //fights with the first athlete , which we skip to add in athletes collection
            var playerIdx = i % athletes.Count;
            bool firstFightIsB;
            if (athletes[playerIdx].isB || _players[0].isB)
            {
                firstFightIsB = true;
            }
            else
            {
                firstFightIsB = false;
                r.Fights.Add(new Fight
                {
                    id = 0, isB = firstFightIsB, Player1 = new GamePlayer(athletes[playerIdx]),
                    Player2 = new GamePlayer(_players[0])
                });
            }

            //the rest of the fights   
            for (var j = 1; j < _players.Count / 2; j++)
            {
                var
                    firstFighterIndex = (i + j) % athletes.Count; //round + iteration shifts the positions in increasing direction with one, the integer leftover division loops over to the first one when we go out of range of the collection  
                var secondFighterIndex = (i + athletes.Count - j) % athletes.Count; // direction is reversed (decreasing)
                bool fighthIsB;
                if (athletes[firstFighterIndex].isB || athletes[secondFighterIndex].isB)
                {
                    fighthIsB = true;
                }
                else
                {
                    fighthIsB = false;
                    r.Fights.Add(new Fight
                    {
                        id = j, isB = fighthIsB, Player1 = athletes[firstFighterIndex],
                        Player2 = athletes[secondFighterIndex]
                    });
                }
            }

            rounds.Add(r);
        }

        return rounds;
    }
}