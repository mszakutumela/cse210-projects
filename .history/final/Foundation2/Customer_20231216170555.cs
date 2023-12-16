using System;

public class Customer
{
    private string _customerName;
    private Address _customerAddress;

    public Customer(string name, Address address)
    {
        _customerName = name;
        _customerAddress = address;
    }

    // public bool FromUSACustomer()
    // {
    //     return _customerAddress.FromUSA();
    // }

    public double Get

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