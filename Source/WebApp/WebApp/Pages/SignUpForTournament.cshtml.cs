using BLL;
using DAL;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages;

[Authorize]
public class SignUpForTournament : PageModel
{
    public TournamentManager tournamentManager;
    public List<Tournament> Tournaments { get; set; }
    public User logedInPLayer { get; set; }

    private IUserDB _userDb;

    public SignUpForTournament(ITournamentDB _tournamentDb, IUserDB _userDb)

    {
        this._userDb = _userDb;
        tournamentManager = new TournamentManager(_tournamentDb);
        Tournaments = tournamentManager.AllTournaments.ToList();
    }


    public void OnGet()
    {
        logedInPLayer = HttpContext.Session.GetObject<User>("User");

        if (logedInPLayer is null)
        {
            var userManager = new UserManager(_userDb);
            HttpContext.Session.SetObject("User", userManager.GetUser(User.Identity.Name));
        }

        logedInPLayer = HttpContext.Session.GetObject<User>("User");
    }

    public void OnPostJoin(string TorID)
    {
        logedInPLayer = HttpContext.Session.GetObject<User>("User");
        var t = tournamentManager.GetTournamentByID(Convert.ToInt32(TorID));
        tournamentManager.AddPlayerToTournament(t, logedInPLayer);
    }

    public void OnPostUnJoin(string TorID)
    {
        logedInPLayer = HttpContext.Session.GetObject<User>("User");
        var t = tournamentManager.GetTournamentByID(Convert.ToInt32(TorID));
        tournamentManager.RemovePlayerFromTournament(t, logedInPLayer);
    }
}