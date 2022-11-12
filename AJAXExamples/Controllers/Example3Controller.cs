using Microsoft.AspNetCore.Mvc;

namespace AJAXExamples.Controllers
{
    public class Example3Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
