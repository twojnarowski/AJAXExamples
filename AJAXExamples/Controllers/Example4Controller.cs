using Microsoft.AspNetCore.Mvc;

namespace AJAXExamples.Controllers
{
    public class Example4Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
