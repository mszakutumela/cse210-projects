using System;

public class Address
{
    private string _street;
    private string _city;
    private string _province;
    public string _country;

    public Address(string street, string city, string province, string country)
    {
        _street = street;
        _city = city;
        _province = province;
        _country = country;
    }

    // public bool FromUSA()
    // {
    //     bool usa = true;
    //     bool notUSA = false;
    //     if (_country == "USA")
    //     {
    //         return usa;
    //     }
    //     else 
    //         return notUSA; 
    // }

    public string GetCountry()
    {
        return _country;
    }
    
    public int GetShippingPrice()
    {
        int shippingCost;
        string country = GetCountry();
        if (country == "USA")
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        return shippingCost;
    }

    // public void SetCountry()
    // {
    //     _country = country;
    // }

    public string GetAddress()
    {
        string address = ($"{_street}, {_city} \n{_province}, {_country}");
        return address;
    }
}