namespace galaxies.Models
{
    public class Planet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Moons { get; set; }
        public string Color { get; set; }
        public int StarId { get; set; }
    }
}