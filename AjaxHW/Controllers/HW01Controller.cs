using Microsoft.AspNetCore.Mvc;

namespace AjaxHW.Controllers
{
    public class HW01Controller : Controller
    {
        public IActionResult index()
        {
            return View();
        }
    }
}
