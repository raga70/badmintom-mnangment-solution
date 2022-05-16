using Entities;

namespace DAL;

public interface ITournamentDB
{
    void AddTournament(Tournament tournament);
    void UpdateTournament(Tournament tournament);
    void DeleteTournament(Tournament tournament);
    List<Tournament> GetAllTournaments();
    void AddPlayerToTournament(Tournament tournament, User player);
    void RemovePlayerFromTournament(Tournament tournament, User player);
}