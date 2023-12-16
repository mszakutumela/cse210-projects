using System;

public class Product
{
    private string _productName;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        _productName = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    
    public double TotalPrice(double price)
    {
        return _price * _quantity;
    }

    public string GetName()
    {
        return _productName;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public double GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
}