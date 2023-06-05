namespace Hometask.Entities
{
    public class Testimonial
    {
        public int Id { get; set; }
        public string Image { get; set; } = null!;
        public string FirstName { get; set; } = null!; 
        public string LastName { get; set; } = null!;
        public string About{ get; set; } = null!;

    }
}
