using System.Collections.Generic;
using DAL;
using Entities;

public class tournamentDBMock : ITournamentDB
{
    public int AddTournament(Tournament tournament)
    {
        return 0;
    }

    public void UpdateTournament(Tournament tournament)
    {
    }

    public void DeleteTournament(Tournament tournament)
    {
    }

    public List<Tournament> GetAllTournaments()
    {
        return new List<Tournament>();
    }

    public void AddPlayerToTournament(Tournament tournament, User player)
    {
    }

    public void RemovePlayerFromTournament(Tournament tournament, User player)
    {
    }
}