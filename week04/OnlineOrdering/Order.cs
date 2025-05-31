using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

   public void AddProduct(Product product, int quantity)
   {
         for (int i = 0; i < quantity; i++)
         {
              _products.Add(product);
         }
   }

   public double CalculateTotalPrice()
   {
       double total = 0;
       foreach (var product in _products)
       {
           total += product.GetPrice();
       }

       // Add shipping cost
       total += _customer.IsInUSA() ? 5.00 : 35.00;
       return total;
   }

   public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }


   public string GetShippingLabel()
   {
       return $"Shipping to: {_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
   }

   // Getters (no setters needed as these are set through methods)
    public List<Product> GetProducts() { return _products; }
    
    public Customer GetCustomer() { return _customer; }
}