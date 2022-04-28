using Entities;
using DAL;

namespace BLL;

public class TournamentManager
{
    private List<Tournament> Tournaments = new List<Tournament>();

    public IList<Tournament> AllTournaments
    {
        get
        {
            if (Tournaments.Count == 0) UpdateAllTournaments();
            return Tournaments.AsReadOnly();
        }
    }

    TournamentDB tournamentDB;

    public TournamentManager()
    {
        tournamentDB = new TournamentDB();
    }

    public void UpdateAllTournaments()
    {
        Tournaments = tournamentDB.GetAllTournaments();
    }

    public void AddTournament(Tournament tournament)
    {
        tournamentDB.AddTournament(tournament);
        Tournaments.Add(tournament);
    }

    public void DeleteTournament(Tournament tournament)
    {
        tournamentDB.DeleteTournament(tournament);
        Tournaments.Remove(tournament);
    }

    public void UpdateTournament(Tournament tournament)
    {
        tournamentDB.UpdateTournament(tournament);
        foreach (var localT in Tournaments)
        {
            if (localT.Tournamnet_id == tournament.Tournamnet_id)
            {
                Tournaments.Remove(localT);
                Tournaments.Add(tournament);
                Tournaments.OrderBy(t => t.Tournamnet_id);
            }
                
        }
    }

    public void AddPlayerToTournament(Tournament tournament, User player)
    { 
        tournamentDB.AddPlayerToTournament(tournament, player);
        Tournaments.Find(t => t.Tournamnet_id == tournament.Tournamnet_id).AddPlayr(player);        

    }

    public void RemovePlayerFromTournament(Tournament tournament, User player)
    {
         tournamentDB.RemovePlayerFromTournament(tournament, player);
         Tournaments.Find(t => t.Tournamnet_id == tournament.Tournamnet_id).RemovePlayer(player);
                   
    }
    
    public Tournament GetTournamentByID(int id)
    {
        

        foreach (var t in Tournaments)
        {
            if (t.Tournamnet_id == id)
            {
                return t;
            }
        }
        return null;
    }
}