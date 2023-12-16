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
            totalPrice += price;
        }
        double shippingPrice = CalculateShippingPrice();
        totalPrice += shippingPrice;

        return totalPrice;
    }

    public double CalculateShippingPrice()
    {
        double shippingPrice = _customer.ForUSACustomer() ? 5 : 35;
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

        foreach (Product product in products)
        {
            totalPrice += product.GetName() + "(" + product.GetProductId() +") - " + "$" + product.GetPrice() + " x " + product.GetQuantity() + " = " + product.TotalPrice();
        }

        totalCost += "Shipping Cost: $" + CalculateShippingPrice() + "\n";
        totalCost += "Total: $" + CalculateTotalPrice();

        return totalCost;
    }

    public void DisplayDetails()
    {
        string packingLabel = GetPackingLabel();
        string shippingLabel = GetShippingLabel();
        string totalPr
    }
}