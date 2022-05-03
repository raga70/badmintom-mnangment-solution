using BLL;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages;

public class tResults : PageModel
{
    public GameResultData Data { get; set; }

    private GameManager _gameManager;
    public ActionResult OnGet(string TorID)
    {
        if (TorID is null) return RedirectToPage("/index");
        TournamentManager tm = new TournamentManager();
        tm.UpdateAllTournaments();
            _gameManager = new GameManager(tm.GetTournamentByID(Convert.ToInt32(TorID)));
        Data = _gameManager.GetTournamentResults();
        if(Data.tournament is null || Data.fightsData is null) return RedirectToPage("/ErroDataIsEMpty");
         return Page();
    }
}