class Customer{
    private string _name;
    private Address _address;
    public void setName(string name){
        _name = name;
    }
    public void setAddress(Address address){
        _address = address;
    }  
    public bool inUsa(){
        if (_address.fromUsa() == true){
            return true;
        }
        return false;
    }

    public string getCustomerName(){
        return _name;
    }

    public string getCustomerAddress(){
        return _address.parseAddress();
    }
}