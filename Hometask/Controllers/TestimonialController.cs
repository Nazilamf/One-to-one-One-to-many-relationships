using Hometask.DAL;
using Hometask.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hometask.Controllers
{
    public class TestimonialController : Controller
    {


        private readonly RelationsDbContext _context;

        public TestimonialController(RelationsDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Testimonial> testimonials = _context.Testimonials.ToList();
            return View(testimonials);
        }

        public IActionResult Details(int id)
        {if (id<=0) return BadRequest();
            Testimonial? testimonial = _context.Testimonials.FirstOrDefault(t=> t.Id == id);
            if (id == null) return NotFound();
            return View(testimonial);
        }
    }
}
