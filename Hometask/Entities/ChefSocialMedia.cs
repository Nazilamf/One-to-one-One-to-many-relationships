namespace Hometask.Entities
{
    public class ChefSocialMedia
    {
        public int Id { get; set; }
        public string FBUrl { get; set; } = null!;
        public string IgURL { get; set; } = null!;
        public string TwitterURl { get; set; } = null!;
        public string InURL { get; set; } = null!;
        public Chef Chef { get; set; } = null!;
        public int ChefId { get; set; }
    }
}
