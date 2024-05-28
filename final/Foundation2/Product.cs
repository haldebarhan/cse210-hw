class Product
{
    private string _productId;
    private string _ProductName;
    private double _price;
    private int _quantity;

    public Product(string id, string name, double price, int quantity)
    {
        _productId = id;
        _ProductName = name;
        _price = price;
        _quantity = quantity;
    }
    public string GetProductId()
    {
        return _productId;
    }

    public string GetProductName()
    {
        return _ProductName;
    }

    public double GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public void SetProductId(string id)
    {
        _productId = id;
    }

    public void SetProductName(string name)
    {
        _ProductName = name;
    }

    public void SetPrice(double price)
    {
        _price = price;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public double TotalCoast()
    {
        return _price * _quantity;
    }
}