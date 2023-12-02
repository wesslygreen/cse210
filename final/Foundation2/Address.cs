class Address{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public void setStreet(string street){
        _street = street;
    }

    public void setCity(string city){
        _city = city;
    }

    public void setState(string state){
        _state = state;
    }

    public void setCountry(string country){
        _country = country;
    }

    public bool fromUsa(){
        if (_country.Equals("United States")){
            return true;
        }
        return false;
    }

    public string parseAddress(){
        return $"{_street},{_city},{_state} {_country}";
    }
}

