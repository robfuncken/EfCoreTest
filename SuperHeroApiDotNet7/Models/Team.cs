namespace SuperHeroApiDotNet7.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public ICollection<SuperHero>  SuperHeroes { get; } = new List<SuperHero>();

    }
}
