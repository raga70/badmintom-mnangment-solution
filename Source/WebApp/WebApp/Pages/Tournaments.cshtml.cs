using BLL;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages;

public class Tournaments : PageModel
{
    
    public TournamentManager tournamentManager;
    public List<Tournament> Tournamentss { get;set; }
    public User logedInPLayer{ get; set; }


    public Tournaments()
    {
        tournamentManager = new TournamentManager();
        Tournamentss = tournamentManager.AllTournaments.ToList();
    }
    
    
    public void OnGet()
    {
        
    }


    public ActionResult OnPostSchedule(string TorID)
    {
       return RedirectToPage("/tSchedule", "SOrder", new { TorID= TorID });
    }

    public ActionResult OnPostResults(string TorID)
    {
        return RedirectToPage("/tResults", "SOrder", new { TorID = TorID });
    }



}