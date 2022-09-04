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
        public IActionResult C8Cal()
        {
            long pricec8 = 12000000;
            long price2c8;
            double moneytopayc8;
            double interestc8;
            double installmentc8;
            long downc8 = Convert.ToInt32(HttpContext.Request.Form["DownC8"].ToString());
            int monthc8 = Convert.ToInt32(HttpContext.Request.Form["MonthC8"].ToString());
            price2c8 = pricec8 - downc8;
            moneytopayc8 = price2c8 / monthc8;
            interestc8 = moneytopayc8 * 0.03;
            installmentc8 = moneytopayc8 + interestc8;

            ViewBag.moneyc8 = downc8.ToString();
            ViewBag.monthc8 = monthc8.ToString();
            ViewBag.interestc8 = interestc8.ToString();
            ViewBag.installmentc8 = installmentc8.ToString();
            return View("Index");
        }

        [HttpPost]
        public IActionResult R8Cal()
        {
            long pricer8 = 18000000;
            long price2r8;
            double moneytopayr8;
            double interestr8;
            double installmentr8;
            long downr8 = Convert.ToInt32(HttpContext.Request.Form["DownR8"].ToString());
            int monthr8 = Convert.ToInt32(HttpContext.Request.Form["MonthR8"].ToString());
            price2r8 = pricer8 - downr8;
            moneytopayr8 = price2r8 / monthr8;
            interestr8 = moneytopayr8 * 0.03;
            installmentr8 = moneytopayr8 + interestr8;

            ViewBag.moneyr8 = downr8.ToString();
            ViewBag.monthr8 = monthr8.ToString();
            ViewBag.interestr8 = interestr8.ToString();
            ViewBag.installmentr8 = installmentr8.ToString();
            return View("Index");
        }

        [HttpPost]
        public IActionResult GTRCal()
        {
            long pricegtr = 15000000;
            long price2gtr;
            double moneytopaygtr;
            double interestgtr;
            double installmentgtr;
            long downgtr = Convert.ToInt32(HttpContext.Request.Form["DownGTR"].ToString());
            int monthgtr = Convert.ToInt32(HttpContext.Request.Form["MonthGTR"].ToString());
            price2gtr = pricegtr - downgtr;
            moneytopaygtr = price2gtr / monthgtr;
            interestgtr = moneytopaygtr * 0.03;
            installmentgtr = moneytopaygtr + interestgtr;

            ViewBag.moneygtr = downgtr.ToString();
            ViewBag.monthgtr = monthgtr.ToString();
            ViewBag.interestgtr = interestgtr.ToString();
            ViewBag.installmentgtr = installmentgtr.ToString();
            return View("Index");
        }
    }
}
