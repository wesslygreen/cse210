class Running : Activity{
    private double distance;
    public Running(double distance){
        this.distance = distance;
        type = "Running";
    }
    public override double calculateSpeed()
    {
        return (distance / length) * 60;
    }
    public override double calculatePace()
    {
        return length / distance;
    }

    public override double calculateDistance()
    {
        return distance;
    }
}