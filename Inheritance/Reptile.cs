namespace Inheritance;

public class Reptile : Animal
{
    public Reptile()
    {
        IsAlive = true;
        LegCount = 4;
        LandSeaAir = "land";
        Age = 0;
    }
    public bool CanSwim { get; set; }
    public string ScaleColor { get; set; }
    public string Habitat { get; set; }
    public bool CanGrowTail { get; set; }
}