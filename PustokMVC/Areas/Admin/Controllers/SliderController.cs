using Microsoft.AspNetCore.Mvc;
using PustokMVC.Contexts;

namespace PustokMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        public async Task<IActionResult> Index()
        {
            using PustokDbContext db = new PustokDbContext();
            return View(await db.Sliders.ToListAsync()); //4.4 
        }
    }
}
