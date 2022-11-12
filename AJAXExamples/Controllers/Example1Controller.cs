using Microsoft.AspNetCore.Mvc;

namespace AJAXExamples.Controllers
{
    public class Example1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
