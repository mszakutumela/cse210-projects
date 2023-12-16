using System;

public class Address
{
    private string _street;
    private string _city;
    private string _province;
    private string _country;

    public Address(string street, string city, string province, string country)
    {
        _street = street;
        _city = city;
        _province = province;
        _country = country;
    }

    public bool FromUSA()
    {
        bool usa = true;
        bool no
        if (_country == "USA")
        {
            return usa;
        }
        else 
            _country = false;
            return _country; 
    }

    public string GetAddress()
    {
        string address = ($"{_street}, {_city} \n {_province}, {_country}");
        return address;
    }
}