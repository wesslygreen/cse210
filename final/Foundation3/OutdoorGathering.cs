class OutdoorGathering : Event{
    private string forecast;
    public OutdoorGathering(){
        this.type = "Outdoor Gathering";
    }
    public void setForecast(string forecast){
        this.forecast = forecast;
    }

    public void getOutdoorDetails(){
        Console.WriteLine();
        getStandardDetails();
        Console.WriteLine($"{type}");
        Console.WriteLine($"{forecast}");
    }
}
