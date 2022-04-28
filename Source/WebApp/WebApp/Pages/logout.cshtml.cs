using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspUser.Pages
{

    [Authorize]
    public class logoutModel : PageModel
    {
        public IActionResult OnGet()
        {
            HttpContext.SignOutAsync();
            HttpContext.Session.Clear();
            return RedirectToPage("/index");
        }
    }
}
