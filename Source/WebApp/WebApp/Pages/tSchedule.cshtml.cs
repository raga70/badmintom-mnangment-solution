using BLL;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages;

public class tSchedule : PageModel
{
    private TournamentManager _tournamentManager = new TournamentManager();
    private GameManager _gameManager;
    public Tournament Tournament { get; set; }
    public List<Round> Rounds { get; set; }

    public ActionResult OnGet(string TorID)
    {
        if (TorID is null) RedirectToPage("/index");
        _tournamentManager.UpdateAllTournaments();
        Tournament = _tournamentManager.GetTournamentByID(Convert.ToInt32(TorID));
        _gameManager = new GameManager(Tournament);
        Rounds = _gameManager.GetSchedule();
        return Page();
    }
}