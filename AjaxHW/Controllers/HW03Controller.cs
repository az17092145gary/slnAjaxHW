using AjaxHW.Models;
using Microsoft.AspNetCore.Mvc;

namespace AjaxHW.Controllers
{
    public class HW03Controller : Controller
    {
        public readonly DemoContext _context;
        public HW03Controller(DemoContext context) 
        {
        _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult City()
        {
            var citys = _context.Addresses.Select(c => new
            {
                c.City
            }).Distinct().OrderBy(a => a.City);
            return Json(citys);
        }
        public IActionResult Site(string city)
        {
            var sites = _context.Addresses.Where(c => c.City == city).Select(c => c.SiteId).Distinct();
            return Json(sites);
        }
        public IActionResult Road(string site)
        {
            var roads = _context.Addresses.Where(c => c.SiteId == site).Select(c => c.Road).Distinct();
            return Json(roads);
        }
    }
}
