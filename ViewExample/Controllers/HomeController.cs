using Microsoft.AspNetCore.Mvc;

namespace ViewExample.Controllers;
public class HomeController : Controller
{
    [Route("home")]
    [Route("/")]
    public IActionResult Index()
    {
        return View();
        //return View("abc");
        //return new ViewResult() { ViewName = "abc" };
    }
}
