using Microsoft.AspNetCore.Mvc;

namespace carWebApplication.Controllers
{
    public class carcal : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult car()
        {
            //int a = Convert.ToInt32(HttpContext.Request.Form["minMoney"].ToString());
            //ViewBag.result = a.ToString();
            return View("cardetail");
        }
    }
    
   
    
   
    
}
