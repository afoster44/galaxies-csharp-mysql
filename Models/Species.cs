namespace galaxies.Models
{
    public class Species
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PlanetId { get; set; }
        public Planet Planet { get; set; }
    }

    public class SpeciesPlanet : Species
    {
        public int SpeciesPlanetId { get; set; }
    }
}