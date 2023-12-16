using System;

public class Customer
{
    private string _customerName;
    private string _customerAddress;

    public Customer(string name, string address)
    {
        _customerName = name;
        _customerAddress = address;
    }

    // public bool FromUSACustomer()
    // {
    //     return _customerAddress.FromUSA();
    // }
    
    public string GetName()
    {
        return _customerName;
    }

    public string GetAddress()
    {
        string getAddress = _customerAddress.GetAddress();

        return getAddress;
    }
}