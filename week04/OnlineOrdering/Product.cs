public class Product 
{
    private string _name;
    private string _productId;
    private double _price;
    private string _description;

    public Product(string name, string productId, double price, string description)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _description = description;
    }


    // Getters and Setters
    public string GetName() { return _name; }

    public void SetName(string name) { _name = name; }

    public string GetProductId() { return _productId; }

    public void SetProductId(string productId) { _productId = productId; }

    public double GetPrice() { return _price; }

    public void SetPrice(double price) { _price = price; }

    public string GetDescription() { return _description; }

    public void SetDescription(string description) { _description = description; }
}