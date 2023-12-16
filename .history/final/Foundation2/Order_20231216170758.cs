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
        double subPrice = 0;
        double totalPrice = 0;
        foreach (Product product in _products)
        {
            double price = product.TotalPrice();
            subPrice += price;
            double shippingPrice = Convert.ToDouble(GetShippingPrice());
            totalPrice = subPrice + shippingPrice;
        }
        // double shippingPrice = Convert.ToDouble(GetShippingPrice());
        // totalPrice += shippingPrice;

        return totalPrice;
    }

    // public bool GetShippingPrice()
    // {
    //     bool shippingPrice = _customer.FromUSACustomer();
        
    //     return shippingPrice;
    // }

    public double GetShippingPrice()
    {
        double shippingCost;
        if (_customerAddress)
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
        string totalPrice = "\nTotal Price: \n";

        foreach (Product product in _products)
        {
        //    totalCost += $"{product.GetName()}: {product.GetProductId()} - ${product.GetPrice()} x {product.GetQuantity()} = {product.TotalPrice()}\n";
            // double total = sum(product);
            // total += product;
            totalPrice += "Shipping Cost: $" + GetShippingPrice() + "\n";
            total += "Total: $" + CalculateTotalPrice();

           
        }
        // totalCost += "Shipping Cost: $" + GetShippingPrice() + "\n";
        // totalCost += "Total: $" + CalculateTotalPrice();
        return totalPrice;
        
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