using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace PLCDataTestApp.Controllers
{
    public class SiemensController:Controller
    {
          public IActionResult Index()
    {
        var model = new SiemensOperationModel();
        return View(model); 
    }

    [HttpPost]
    public IActionResult Index(SiemensOperationModel model)
    {
        return View(model); 
    }
    }
}