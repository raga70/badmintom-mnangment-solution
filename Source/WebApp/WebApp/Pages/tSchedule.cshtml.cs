using BLL;
using DAL;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages;

public class tSchedule : PageModel
{
    private TournamentManager _tournamentManager;
    //private GameManager _gameManager;
    public Tournament Tournament { get; set; }
    public List<Round> Rounds { get; set; }

    public string ErrMsg { get; set; }

    public tSchedule(IGameDB gameDb, ITournamentDB tournamentDb)
    {
       
        _tournamentManager = new TournamentManager(tournamentDb,gameDb);
    }

    public ActionResult OnGet(string TorID)
    {
        if (TorID is null) RedirectToPage("/index");
        _tournamentManager.UpdateAllTournaments();
        Tournament = _tournamentManager.GetTournamentByID(Convert.ToInt32(TorID));
        _tournamentManager.UpdateAllTournaments();
        if (((TournamentInPlay)_tournamentManager.GetTournamentByID(Convert.ToInt32(TorID))).GetType() ==
            typeof(TournamentSE))
        {
            ErrMsg = "This tournament uses a single-elimination TournamentSystem and cannot generate the full schedule (i didnt had enough time to implement TimeTravel :)";
            return Page();
        }
            
            
            
        Rounds = ((TournamentInPlay)_tournamentManager.GetTournamentByID(Convert.ToInt32(TorID))).AllRounds.ToList();
        return Page();
    }
}