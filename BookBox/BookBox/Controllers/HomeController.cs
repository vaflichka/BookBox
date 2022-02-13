using BookBox.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BookBox.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        <font style = "vertical-align: inherit;" >< font style="vertical-align: inherit;">използване на системата;</font></font><font></font><font style = "vertical-align: inherit;" >< font style="vertical-align: inherit;">
 System.Collections.Generic;</font></font><font></font><font style = "vertical-align: inherit;" >< font style="vertical-align: inherit;">
 System.Linq;</font></font><font></font><font style = "vertical-align: inherit;" >< font style="vertical-align: inherit;">
 System.Web;</font></font><font></font><font style = "vertical-align: inherit;" >< font style="vertical-align: inherit;">
System.Web.Mvc;</font></font><font></font><font style = "vertical-align: inherit;" >< font style="vertical-align: inherit;">
 BookStore.Models;</font></font><font></font>
<font></font><font style = "vertical-align: inherit;" >< font style="vertical-align: inherit;">
пространство от имена BookStore.Controllers</font></font><font></font><font style = "vertical-align: inherit;" >< font style= "vertical-align: inherit;" >
{</ font ></ font >< font ></ font >< font style = "vertical-align: inherit;" >< font style = "vertical-align: inherit;" >
                 публичен клас HomeController : Контролер </ font ></ font >< font ></ font >< font style = "vertical-align: inherit;" >< font style = "vertical-align: inherit;" >
    {</ font ></ font >< font ></ font >< font style = "vertical-align: inherit;" >< font style = "vertical-align: inherit;" >
                     // създаване на контекст на данни</font></font><font></font><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">
                     BookContext db = нов BookContext();</ font ></ font >< font ></ font >
             < font ></ font >< font style = "vertical-align: inherit;" >< font style = "vertical-align: inherit;" >
                              публичен ActionResult Index()</ font ></ font >< font ></ font >< font style = "vertical-align: inherit;" >< font style = "vertical-align: inherit;" >
        {</ font ></ font >< font ></ font >< font style = "vertical-align: inherit;" >< font style = "vertical-align: inherit;" >
                         // получаваме всички обекти на Book от базата данни</font></font><font></font><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">
                         IEnumerable < Book > books = db.Books;</ font ></ font >< font ></ font >< font style = "vertical-align: inherit;" >< font style = "vertical-align: inherit;" >
                                         // предава всички обекти към динамичното свойство Books във ViewBag</font></font><font></font><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">
                                         ViewBag.Books = книги;</ font ></ font >< font ></ font >< font style = "vertical-align: inherit;" >< font style = "vertical-align: inherit;" >
                                                      // връщане на изглед</font></font><font></font><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">
                                                      returnView();</ font ></ font >< font ></ font >< font style = "vertical-align: inherit;" >< font style = "vertical-align: inherit;" >
        }</ font ></ font >< font ></ font >< font style = "vertical-align: inherit;" >< font style = "vertical-align: inherit;" >
    }</ font ></ font >< font ></ font >< font style = "vertical-align: inherit;" >< font style = "vertical-align: inherit;" >
    }
}