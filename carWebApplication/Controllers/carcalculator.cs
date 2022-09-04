using Microsoft.AspNetCore.Mvc;

namespace carWebApplication.Controllers
{
    public class carcalculator : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Carcal()
        {
            int a = Convert.ToInt32(HttpContext.Request.Form["Minmoney"].ToString());
            ViewBag.result = a.ToString();
            return View("Index");
        }
    }
}
