using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entities.DTO;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using BLL;
using DAL;
using Entities;

namespace WebApp.Pages;

public class RegisterModel : PageModel
{
    private passwordHashing passHasher = new();
    private UserManager userManager;
    [BindProperty] public Register bRegister { get; set; }
    public string errMsg { get; private set; }

    public void OnGet()
    {
    }

    public RegisterModel(IUserDB _userDb)
    {
        userManager = new UserManager(_userDb);
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

    public ActionResult OnPostRegister()
    {
        if (ModelState.IsValid)
        {
            bRegister.password = passHasher.Hash(bRegister.password);
            if (!userManager.RegisterUser(new User(bRegister)))
            {
                errMsg = "the username is taken";
                return Page();
            }

            Auth(bRegister.username);
            return RedirectToPage("/index");
        }

        return Page();
    }
}