using Microsoft.AspNetCore.Mvc;

namespace WebAPICookie.Controllers
{
    public class Employee : Controller
    {
        public IActionResult create ()
        {
            string key = "DemoCookie";
            string value = DateTime.Now.ToString();

            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddDays(7);
            Response.Cookies.Append(key, value, options);
            return View();

        }
        public IActionResult Read()
        {
            string key = "DemoCookie";
            var CookieValue = Request.Cookies[key];
            ViewBag.abc = CookieValue;
            return View();
        }
        //removing cookie
        public IActionResult Remove()
        {
            string key = "DemoCookie";
            string value = DateTime.Now.ToString();

            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Append(key, value, options);

            return View();
        }

 }
}
