using BLL;
using DAL;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages;

public class tResults : PageModel
{
    private IGameDB _gameDB;

    // private TournamentManager _tournamentManager;

    private ITournamentDB _tournamentDB;

    public tResults(ITournamentDB _tournamentDb, IGameDB _gameDb)
    {
        _gameDB = _gameDb;

        _tournamentDB = _tournamentDb;
    }

    public GameResultData Data { get; set; }

    public ActionResult OnGet(string TorID)
    {
        if (TorID is null) return RedirectToPage("/index");
        var tm = new TournamentManager(_tournamentDB, _gameDB);
        tm.UpdateAllTournaments();
        //_gameManager = new GameManager(_gameDB, tm.GetTournamentByID(Convert.ToInt32(TorID)));
        Data = tm.GetTournamentResults(tm.GetTournamentByID(Convert.ToInt32(TorID)));
        if (Data.tournament is null || Data.fightsData is null) return RedirectToPage("/ErroDataIsEMpty");
        return Page();
    }
}