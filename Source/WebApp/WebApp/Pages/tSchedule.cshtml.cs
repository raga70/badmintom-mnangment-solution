using BLL;
using DAL;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages;

public class tSchedule : PageModel
{
    private TournamentManager _tournamentManager;
    private GameManager _gameManager;
    public Tournament Tournament { get; set; }
    public List<Round> Rounds { get; set; }

    private IGameDB _gameDB;

    public tSchedule(IGameDB gameDb, ITournamentDB tournamentDb)
    {
        _gameDB = gameDb;
        _tournamentManager = new TournamentManager(tournamentDb);
    }

    public ActionResult OnGet(string TorID)
    {
        if (TorID is null) RedirectToPage("/index");
        _tournamentManager.UpdateAllTournaments();
        Tournament = _tournamentManager.GetTournamentByID(Convert.ToInt32(TorID));
        _gameManager = new GameManager(_gameDB, Tournament);
        Rounds = _gameManager.GetSchedule();
        return Page();
    }
}