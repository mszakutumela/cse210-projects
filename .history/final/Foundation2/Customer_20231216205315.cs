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

    public int GetShippingPrice()
    {
        int shippingCost;
        string address = AddressGetCountry();
        if (address == "USA")
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        return shippingCost;
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