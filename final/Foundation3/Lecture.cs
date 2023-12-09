class Lecture : Event{
    private string speaker;
    private int capacity;
    public Lecture(){
        this.type = "Lecture";
    }
    public void setSpeaker(string speaker){
        this.speaker = speaker;
    }
    public void setCapacity(int capacity){
        this.capacity = capacity;
    }

    public void getLectureDetails(){
        Console.WriteLine();
        getStandardDetails();
        Console.WriteLine($"{type}");
        Console.WriteLine($"{speaker}");
        Console.WriteLine($"{capacity}");
    }
}