class Order{
    private List<Product> listOfProducts = new List<Product>();
    private Customer _customer;
    private int _shipping;

    public void setCustomer(Customer customer){
        _customer = customer;

        if (_customer.inUsa() == true){
            _shipping = 5;
        }
        else{
            _shipping = 35;
        }
    }

    public void addToList(Product product){
        listOfProducts.Add(product);
    }

    public void printPackingLabel(){
        int index = 1;
        foreach (Product product in listOfProducts){
            Console.WriteLine($"{index}. {product.getInfo()}");
        }
    }

    public void printShippingLabel(){
        Console.WriteLine($"{_customer.getCustomerName()} - {_customer.getCustomerAddress()}");
    }

    public void addToOrder(Product product){
        listOfProducts.Add(product);
    }

    public double getOrderCost(){
        double cost = _shipping;
        foreach (Product p in listOfProducts){
            cost += p.getTotalPrice();
        }
        return cost;
    }
}