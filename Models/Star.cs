namespace galaxies.Models
{
    public class Star
    {     
    public int Id { get; set; }
    public string Name { get; set; }    
    public int Age { get; set; }
    public string Size { get; set; }
    public string Mass { get; set; }
    public int GalaxyId { get; set; }
    public Galaxy Galaxy { get; set; }
    }
}