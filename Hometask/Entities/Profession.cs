namespace Hometask.Entities
{
    public class Profession
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<Chef> Chefs { get; set; } = null!;

    }
}
