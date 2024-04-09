using Microsoft.AspNetCore.Mvc;
using assetManager.Models;
using System.Diagnostics;
using System.Reflection;

namespace assetManager.Controllers
{
    public class HomeController : Controller
    {
        // GET /Home/About
        public IActionResult About()
        {
            var location    = Assembly.GetExecutingAssembly().Location;
            var versionInfo = FileVersionInfo.GetVersionInfo(location);

            var model = new About
            {
                AppName   = ("Portal quản lý tài sản Base.vn" ),
                Copyright = ("Thành Đỗ _ Base.vn"),
                Url       = "xxxxxxx",
                Version   = ("Version 1.1" )
            };

            return View(model);
        }

        // GET /Home/Error
        public IActionResult Error()
        {
            var model = new ErrorViewModel
            {
                RequestId = (Activity.Current?.Id ?? HttpContext.TraceIdentifier)
            };

            return View(model);
        }

        // GET [ /, /Home/, /Home/Index ]
        public IActionResult Index()
        {

            return View();
        }
    }
}
