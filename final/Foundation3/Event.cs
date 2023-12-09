class Event{
    protected string title;
    protected string descrip;
    protected string date;
    protected string time;
    protected string address;
    protected string type;
    public void setTitle(string title){
        this.title = title;
    }
    public void setDescription(string descrip){
        this.descrip = descrip;
    }
    public void setDate(string date){
        this.date = date;
    }
    public void setTime(string time){
        this.time = time;
    }
    public void setAddress(string address){
        this.address = address;
    }
    public void getStandardDetails(){
        Console.WriteLine();
        Console.WriteLine($"{title}");
        Console.WriteLine($"{descrip}");
        Console.WriteLine($"{date}");
        Console.WriteLine($"{time}");
        Console.WriteLine($"{address}");
    }
    public void getShortDescription(){
        Console.WriteLine();
        Console.WriteLine($"{type}");
        Console.WriteLine($"{title}");
        Console.WriteLine($"{date}");
    }
}