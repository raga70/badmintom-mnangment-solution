using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BLL;
namespace WebApp.Pages
{
    public class loginModel : PageModel
    {

        UserManager um = new UserManager();
        public string errMsg { get; private set; }
        
        public void OnGet()
        {
        }


        public async void Auth(string user)
        {

            var authProperties = new AuthenticationProperties
            {


                ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(28),
                //IsPersistent = false,

            };

            List<Claim> claimsss = new List<Claim>();
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
                Auth(user);
                return RedirectToPage("/index");
            }

            errMsg = "Wrong Credentials";
            return Page();
        }


    }
}
