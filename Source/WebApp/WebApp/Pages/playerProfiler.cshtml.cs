using DAL;
using Entities;
using BLL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages;

[Authorize]
public class playerProfiler : PageModel
{
   // private IUserDB _userDb;
   private UserManager userManager;
    
    public playerProfiler( IUserDB userDb,IGameDB gameDb)
    {
      userManager = new UserManager(userDb,gameDb);
    }

    public int Rank
    {
        get
        {
            int a = 0;
            foreach (var t in Data)
            {
                a = a + t.playerPoints;
            }

            return a;
        }
    }

    public User logedInPLayer { get; set; }
    
    public List<GameResultData> Data { get; set; }

    public void OnGet()
    {
        logedInPLayer = HttpContext.Session.GetObject<User>("User");

        if (logedInPLayer is null)
        {
            
            HttpContext.Session.SetObject("User", userManager.GetUser(User.Identity.Name));
        }

        logedInPLayer = HttpContext.Session.GetObject<User>("User");
        
        
        Data = userManager.GetPlayerProfiler(logedInPLayer);
        
    }
}