using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace PLCDataTestApp.Controllers
{
    public class ModbusController:Controller
    {
    public IActionResult Index()
    {
       var model = new ModbusOperationModel
            {
                Connection = true 
            };
            return View(model);
    }

    [HttpPost]
    public IActionResult Index(ModbusOperationModel model)
    {
        return View(model); 
    }
    }
}

