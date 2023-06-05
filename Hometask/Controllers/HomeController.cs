using Hometask.DAL;
using Microsoft.AspNetCore.Mvc;
using Hometask.Controllers;
using Hometask.Entities;
using Microsoft.EntityFrameworkCore;
using Hometask.ViewModel;
using System.Collections.Generic;


namespace Hometask.Controllers
{
    public class HomeController : Controller
    {
        private readonly RelationsDbContext _context;
        public HomeController(RelationsDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ChefTestimonialVM model = new ChefTestimonialVM()
            {
                Chefs = _context.Chefs.Include(c => c.ChefSocialMedia).Include(ch => ch.Profession).ToList(),
                Testimonial = _context.Testimonials.ToList()

            };
            return View(model);
        }
            

    }
}
    


        
    



      

