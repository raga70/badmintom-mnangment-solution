using BLL;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages;

[Authorize]
public class SignUpForTournament : PageModel
{
    
    public TournamentManager tournamentManager;
    public List<Tournament> Tournaments { get;set; }
    public User logedInPLayer{ get; set; }


    public SignUpForTournament()
    {
        tournamentManager = new TournamentManager();
        Tournaments = tournamentManager.AllTournaments.ToList();
    }


    public void OnGet()
    {
        
        

        if (HttpContext.Session.GetObject<User>("User") is null)
        {
            UserManager userManager = new UserManager();
            HttpContext.Session.SetObject("User",userManager.GetUser(User.Identity.Name));
        }
        logedInPLayer = HttpContext.Session.GetObject<User>("User");
        
    }

    public void OnPostJoin(string TorID)
    {
        logedInPLayer = HttpContext.Session.GetObject<User>("User");
        Tournament t = tournamentManager.GetTournamentByID(Convert.ToInt32(TorID));
        tournamentManager.AddPlayerToTournament(t, logedInPLayer);   

    }
    
    public void OnPostUnJoin(string TorID)
    {
        Tournament t = tournamentManager.GetTournamentByID(Convert.ToInt32(TorID));
        tournamentManager.RemovePlayerFromTournament(t, logedInPLayer);
    }
    
    
}