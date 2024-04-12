using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NguyenTruongBach_2180605467.Models;

namespace NguyenTruongBach_2180605467.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = SD.Role_Admin)]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}