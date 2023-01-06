using AjaxHW.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace AjaxHW.Controllers
{
    public class HW02Controller : Controller
    {
        public readonly DemoContext _context;
        public HW02Controller(DemoContext context) { 
        
        _context = context;
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult check(string? name)
        {
            var ch = _context.Members.Where(x => x.Name.Equals(name)).ToList();
            if (ch.Count != 0) {
                return Content("false", "text/plain", Encoding.UTF8);
            }
            return Content("", "text/plain", Encoding.UTF8);
        }
    }
}
