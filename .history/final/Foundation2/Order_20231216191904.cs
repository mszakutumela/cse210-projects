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

    public double CalculateSubtotalPrice()
    {
        double subTotalPrice = 0;
        foreach (Product product in _products)
        {
            double price = 0;
            double quantity = 0;
            price = product.TotalPrice(price, quantity);
            subTotalPrice += price;
            // subPrice += price;
            // double shippingPrice = Convert.ToDouble(GetShippingPrice());
            // totalPrice = subPrice + shippingPrice;
        }
        // double shippingPrice = Convert.ToDouble(GetShippingPrice());
        // totalPrice += shippingPrice;

        return subTotalPrice;
    }

    // public bool GetShippingPrice()
    // {
    //     bool shippingPrice = _customer.FromUSACustomer();
        
    //     return shippingPrice;
    // }

    // public double GetShippingPrice()
    // {
    //     double shippingCost;
    //     Address address = GetCountry();
    //     if (address == "USA")
    //     {
    //         shippingCost = 5;
    //     }
    //     else
    //     {
    //         shippingCost = 35;
    //     }

    //     return shippingCost;
    // }

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

    public string GetTotalPrice()
    {
        string totalPrice = "\nTotal Price: \n";
        double subtotal = CalculateSubtotalPrice();
        int shippingCost = Address.GetShippingPrice();

        foreach (Product product in _products)
        {
           totalCost += $"{product.GetName()}: {product.GetProductId()} - ${product.GetPrice()} x {product.GetQuantity()} = {product.TotalPrice()}\n";
            // double total = sum(product);
            // total += product;

            // double subTotal = product.CalculateSubtotalPrice();
            // int shippingCost = product.GetShippingPrice();
            // totalPrice += subTotal + shippingCost;           
        }
        // totalCost += "Shipping Cost: $" + GetShippingPrice() + "\n";
        // totalCost += "Total: $" + CalculateTotalPrice();
        return totalPrice;

        Console.WriteLine($"Subtotal Price: {subtotal}");
        Console.WriteLine($"Shipping Price: {shippingCost}");
        Console.WriteLine($"Total Price: {total}");

        
    }

    public void DisplayDetails()
    {
        string packingLabel = GetPackingLabel();
        string shippingLabel = GetShippingLabel();
        string totalPrice = GetTotalPrice();

        Console.WriteLine(packingLabel);
        Console.WriteLine(shippingLabel);
        Console.WriteLine(totalPrice);
    }
}