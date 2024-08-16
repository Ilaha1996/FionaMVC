using FionaMVC.DAL;
using Microsoft.EntityFrameworkCore;
using FionaMVC.Entities;
using FionaMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace FionaMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDBContext _context;
        public HomeController(AppDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            HomeVM homeVM = new HomeVM
            {
                Slides = _context.Slides.OrderBy(s => s.Id).Take(2).ToList(),
               
            };
            return View(homeVM);
        }
    }
}
