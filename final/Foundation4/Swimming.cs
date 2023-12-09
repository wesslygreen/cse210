class Swimming : Activity{
    private int laps;
    public Swimming(int laps){
        this.laps = laps;
        type = "Swimming";
    }
    public override double calculateDistance()
    {
        return laps * 50 / 1000 * 0.62;
    }
    public override double calculateSpeed()
    {
        double distance = laps * 50 / 1000 * 0.62;
        return (distance / length) * 60;
    }

    public override double calculatePace()
    {
        double distance = laps * 50 / 1000 * 0.62;
        double speed = (distance / length) * 60;
        return 60 / speed;
    }
}