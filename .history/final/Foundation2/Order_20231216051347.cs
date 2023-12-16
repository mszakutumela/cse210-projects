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
            // totalPrice += price;
        }
        bool shippingPrice = GetShippingPrice();
        totalPrice  = shippingPrice;

        return totalPrice;
    }

    public bool GetShippingPrice()
    {
        bool shippingPrice = _customer.FromUSACustomer();
        // int shippingPrice = 0;
        // customer = _customer;

        // if (customer == "USA")
        // {
        //     double shippingPrice = 5;
        // }
        // else if (customer != "USA")
        // {
        //     double shippingPrice = 35;
        // }
        return shippingPrice;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label: \n";
        shippingLabel += _customer.GetName() + "\n" + _customer.GetAddress();
        
        return shippingLabel;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label: \n";

        foreach (Product product in _products)
        {
            packingLabel += product.GetName() + "-" + product.GetProductId() + "\n";
        }

        return packingLabel;
    }

    public string GetTotalCost()
    {
        string totalCost = "\nProducts: \n";
        double totalPrice = CalculateTotalPrice();

        foreach (Product product in _products)
        {
           return $"{product.GetName()}: {product.GetProductId()} - ${product.GetPrice()} x {product.GetQuantity()} = {product.TotalPrice()}";
        }

        totalCost += "Shipping Cost: $" + GetShippingPrice() + "\n";
        totalCost += "Total: $" + CalculateTotalPrice();

        return totalCost;
    }

    public void DisplayDetails()
    {
        string packingLabel = GetPackingLabel();
        string shippingLabel = GetShippingLabel();
        string totalCost = GetTotalCost();

        Console.WriteLine(packingLabel);
        Console.WriteLine(shippingLabel);
        Console.WriteLine(totalCost);
    }
}