class Product{
    private string _name;
    private int _id;
    private double _price;
    private int _quantity;

    public Product(string name, int id, double price, int quantity){
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }
    public void setName(string name){
        _name = name;
    }

    public void setId(int id){
        _id = id;
    }

    public void setPrice(int price){
        _price = price;
    }

    public void setQuantity(int quantity){
        _quantity = quantity;
    }

    public double getTotalPrice(){
        return _quantity * _price;
    }

    public string getInfo(){
        return $"{_name} - {_quantity}";
    }
}