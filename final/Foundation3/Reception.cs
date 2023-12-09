class Reception : Event{
    private int registered;
    public Reception(){
        this.type = "Reception";
    }
    public void setRegistered(int registered){
        this.registered = registered;
    }

    public void getReceptionDetails(){
        Console.WriteLine();
        getStandardDetails();
        Console.WriteLine($"{type}");
        Console.WriteLine($"{registered}");
    }
}