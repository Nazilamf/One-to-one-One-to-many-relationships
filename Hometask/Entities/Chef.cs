 namespace Hometask.Entities
{
    public class Chef
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int ProfessionId { get; set; }
        public Profession Profession { get; set; } = null!;
        public ChefSocialMedia ChefSocialMedia { get; set; } = null!;

        public string Image { get; set; } = null!;
    }
  
}
   

