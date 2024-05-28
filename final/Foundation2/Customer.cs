class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public Address SetAddress()
    {
        return _address;
    }


    public bool LivesInUsa()
    {
        return _address.ComesFromTheUsa();
    }
}