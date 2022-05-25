using Entities;
using DAL;

namespace BLL;

public class TournamentManager
{
    private List<Tournament> Tournaments = new();

    public IList<Tournament> AllTournaments
    {
        get
        {
            if (Tournaments.Count == 0) UpdateAllTournaments();
            return Tournaments.AsReadOnly();
        }
    }

    private ITournamentDB tournamentDB;

    private IGameDB _gameDB;

    public TournamentManager(ITournamentDB passed)
    {
        tournamentDB = passed;
    }
    
    public TournamentManager(ITournamentDB passed, IGameDB passedGameDb)
    {
        tournamentDB = passed;
        _gameDB = passedGameDb;
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
        foreach (var localT in Tournaments)
            if (localT.Tournamnet_id == tournament.Tournamnet_id)
            {
                Tournaments.Remove(localT);
                Tournaments.Add(tournament);
                Tournaments.OrderBy(t => t.Tournamnet_id);
                break;
            }

        tournamentDB.UpdateTournament(tournament);
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
            if (t.Tournamnet_id == id)
                return t;
        return null;
    }
    
    ///game manangment
    
    
    
    public void SaveGame(Tournament tGame)
    {
        //check if badminton rules are followed corectly

        ((TournamentInPlay)tGame).UpdateGame();
        _gameDB.PushTournament(tGame, ((TournamentInPlay)tGame).AllRounds.ToList());
        // if (tGame.TournamentSystem == TournamentSystems.SingleElimination) //REMOVE 
        //     ((TournamentGame)tGame).CreteSchedule(((TournamentGame)tGame).AllRounds.ToList());
    }

    
    //no point in keeping a local copy because on  each new OnPost() in razor it gets garbage collected 
    public GameResultData GetTournamentResults(Tournament t)
    {
        return _gameDB.GetGameResults(t);
    }

    
    
    
    
    
    
    
    
}