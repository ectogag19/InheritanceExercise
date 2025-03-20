namespace Inheritance;

public class Bird : Animal
{
    public Bird()
    {
        IsAlive = true;
        LegCount = 2;
        LandSeaAir = "air";
        Age = 0;
    }
    public string BeakShape { get; set; }
    public double Wingspan  { get; set; }
    public string FeatherColor { get; set; }
    public bool CanFly { get; set; }
}