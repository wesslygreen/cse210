class Activity{
    protected string date;
    protected int length;
    protected string type;
    public void setDate(string date){
        this.date = date;
    }
    public void setLength(int length){
        this.length = length;
    }
    public virtual double calculateSpeed(){
        return 0.0;
    }
    public virtual double calculatePace(){
        return 0.0;
    }

    public virtual double calculateDistance(){
        return 0.0;
    }
    public void getSummary(){
        Console.WriteLine($"{date} {type} ({length} min)- Distance: {calculateDistance():0.00} miles, Speed: {calculateSpeed():0.00} mph, Pace: {calculatePace():0.00} min per mile");
    }
}