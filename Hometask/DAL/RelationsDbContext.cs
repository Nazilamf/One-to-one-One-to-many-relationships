using Hometask.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hometask.DAL
{
    public class RelationsDbContext:DbContext
    {
        public RelationsDbContext(DbContextOptions<RelationsDbContext> options) : base(options)
        {

        }

        public DbSet<Chef> Chefs { get; set; } = null!;
        public DbSet<ChefSocialMedia> ChefSocialMedias { get; set; } = null!;
        public DbSet <Profession> Professions { get; set; } = null!;
        public DbSet <Testimonial> Testimonials { get; set; } = null!;
    }
}
