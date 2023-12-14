using System;

public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(List<Product> products, Customer customer)
    {
        _customer = customer;
        _products = products;
    }

    public double CalculateTotalPrice()
    {
        double totalPrice = 0;
        foreach (Product product in _products)
        {
            double price = product.TotalPrice();
            totalPrice += 
        }
    }

    public double CalculateShippingPrice()
    {
        double shippingPrice = _customer.ForUSACustomer() ? 5 : 35;
        return shippingPrice;
    }

    public string GetShippingLabel()
    {

    }

    public string GetPackingLabel()
    {
        
    }
}