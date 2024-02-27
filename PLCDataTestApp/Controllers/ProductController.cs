using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Contracts;
using Services.Contracts;

namespace PLCDataTestApp.Controllers
{
    public class ProductController :Controller
    {
        private readonly IServiceManager _manger;

        public ProductController(IServiceManager manger)
        {
            _manger = manger;
        }

        public IActionResult Index()
        {
            var model = _manger.ProductService.GetAllProduct(false);
            return View(model);
        }

        public IActionResult Get([FromRoute(Name="id")] int id)
        {
            var model = _manger.ProductService.GetOneProduct(id,false);
            return View(model);
        }
    }
}