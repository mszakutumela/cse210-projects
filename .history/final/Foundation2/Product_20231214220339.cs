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
    
    public double TotalPrice()
    {
        return _price * 
    }
}