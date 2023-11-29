using FirstWebApplication.Helpers;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace FirstWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var dt = await SqlHelper.GetDatas("SELECT * FROM Authors");
            return View(dt);
        }
        public IActionResult Contact()
        {
            return View();
        }







    }
    
    
}