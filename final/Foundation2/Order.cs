class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = [];
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double TotalCoast()
    {
        double total = _products.Sum(p => p.TotalCoast());
        double shippingCoast = _customer.LivesInUsa() ? 5 : 35;
        return total + shippingCoast;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetProductName()} ({product.GetProductId()})\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += $"{_customer.GetName()}\n";
        shippingLabel += $"{_customer.GetAddress().FullAddress()}";
        return shippingLabel;
    }
}