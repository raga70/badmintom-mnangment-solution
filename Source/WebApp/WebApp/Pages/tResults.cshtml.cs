using BLL;
using DAL;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages;

public class tResults : PageModel
{
    public GameResultData Data { get; set; }

    private GameManager _gameManager;

    private ITournamentDB _tournamentDB;
    private IGameDB _gameDB;

    public tResults(ITournamentDB _tournamentDb, IGameDB _gameDb)
    {
        _gameDB = _gameDb;

        _tournamentDB = _tournamentDb;
    }

    public ActionResult OnGet(string TorID)
    {
        if (TorID is null) return RedirectToPage("/index");
        var tm = new TournamentManager(_tournamentDB);
        tm.UpdateAllTournaments();
        _gameManager = new GameManager(_gameDB, tm.GetTournamentByID(Convert.ToInt32(TorID)));
        Data = _gameManager.GetTournamentResults();
        if (Data.tournament is null || Data.fightsData is null) return RedirectToPage("/ErroDataIsEMpty");
        return Page();
    }
}