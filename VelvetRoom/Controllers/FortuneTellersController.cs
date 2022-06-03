using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace VelvetRoom.Controllers
{
    public class FortuneTellersController : Controller
    {
        public IActionResult FortuneTelling()
        {
            return View();
        }
    }
}
