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

    public bool ForUSACustomer()
    {
        return _customerAddress.ForUSA();
    }

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