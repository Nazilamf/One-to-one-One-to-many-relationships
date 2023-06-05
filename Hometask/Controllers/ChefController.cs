using Hometask.DAL;
using Hometask.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hometask.Controllers
{
    public class ChefController : Controller
    {
        private readonly RelationsDbContext _context;
        public ChefController(RelationsDbContext context)
        {
            _context=context;
        }

        public IActionResult Index()
        {
            List<Chef> chefs = _context.Chefs.Include(c => c.ChefSocialMedia).Include(ch => ch.Profession).ToList();
            return View(chefs);
        }

        public IActionResult Details(int id)
        {
            if (id <=0) return BadRequest();
            Chef?chefs = _context.Chefs.Include(c => c.ChefSocialMedia).Include(ch => ch.Profession).FirstOrDefault(x => x.Id==id);
            if (chefs == null) return NotFound();
            return View(chefs);
        }
    }
}
