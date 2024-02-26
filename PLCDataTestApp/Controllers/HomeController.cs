using Microsoft.AspNetCore.Mvc;

namespace PLCDataTestApp.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}