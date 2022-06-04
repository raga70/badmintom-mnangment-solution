using BLL;
using DAL;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages;

public class Tournaments : PageModel
{
    public TournamentManager tournamentManager;


    public Tournaments(ITournamentDB _tournamentDb)
    {
        tournamentManager = new TournamentManager(_tournamentDb);
        Tournamentss = tournamentManager.AllTournaments.ToList();
    }

    public List<Tournament> Tournamentss { get; set; }
    public User logedInPLayer { get; set; }


    public void OnGet()
    {
    }


    public ActionResult OnPostSchedule(string TorID)
    {
        return RedirectToPage("/tSchedule", "SOrder", new { TorID });
    }

    public ActionResult OnPostResults(string TorID)
    {
        return RedirectToPage("/tResults", "SOrder", new { TorID });
    }
}