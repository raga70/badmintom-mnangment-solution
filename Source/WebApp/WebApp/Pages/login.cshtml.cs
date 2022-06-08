using System.Security.Claims;
using BLL;
using DAL;
using Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages;

public class loginModel : PageModel
{
    private UserManager um;


    public loginModel(IUserDB _userDb)
    {
        um = new UserManager(_userDb);
    }

    public string errMsg { get; private set; }

    public void OnGet()
    {
    }


    public async void Auth(string user)
    {
        var authProperties = new AuthenticationProperties
        {
            ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(28)
            //IsPersistent = false,
        };

        var claimsss = new List<Claim>();
        claimsss.Add(new Claim(ClaimTypes.Name, user));


        var claimsIdentity = new ClaimsIdentity(claimsss, CookieAuthenticationDefaults.AuthenticationScheme);


        await HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity), authProperties);
    }

    public ActionResult OnPostLogin()
    {
        var user = Request.Form["user"];
        var pass = Request.Form["pass"];
        if (um.Login(user, pass))
        {
            if (um.GetUser(user).accType == AccTypes.Athlete)
            {
                Auth(user);
                return RedirectToPage("/index");
            }
        }

        errMsg = "Wrong Credentials";
        return Page();
    }
}



