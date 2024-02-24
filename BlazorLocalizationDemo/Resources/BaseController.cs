using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace BlazorLocalizationDemo.Resources
{
    public class BaseController : Controller
    {
        public IActionResult SetCulture(string culture, string redirectUri)
        {                
            if (culture != null)
            {
                Response.Cookies.Append(
                    CookieRequestCultureProvider.DefaultCookieName,
                    CookieRequestCultureProvider.MakeCookieValue(
                        new RequestCulture(culture)),
                        new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1), Secure = true, SameSite = SameSiteMode.None });
            }

            return LocalRedirect(redirectUri);
        }
    }
}
