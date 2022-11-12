using Microsoft.AspNetCore.Mvc;

namespace AJAXExamples.Controllers
{
    public class Example2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
