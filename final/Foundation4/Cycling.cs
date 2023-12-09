using System.Reflection.Metadata.Ecma335;

class Cycling : Activity{
    private double speed;
    public Cycling(double speed)
    {
        this.speed = speed;
        type = "Cycling";
    }

    public override double calculateSpeed()
    {
        return speed;
    }
    public override double calculatePace()
    {
        return 60 / speed;
    }
    public override double calculateDistance()
    {
        return (speed / 60) * length;
    }
}