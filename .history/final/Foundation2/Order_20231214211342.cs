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

    public float CalculateTotalPrice()
    {
        double shippingCost = _customer.ForUSACustomer() ? 5 : 35;
        return 
    }

    public string GetShippingLabel()
    {

    }

    public string GetPackingLabel()
    {
        
    }
}