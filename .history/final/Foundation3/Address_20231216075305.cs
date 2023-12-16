using System;

public class Address
{
    private string _street {get; set;}
    private string _city {get; set;}
    private string _province {get; set;}
    private string _country;
    private int _postalCode;

    public Address(string street, string city, string province, string country, int code)
    {
        _street = street;
        _city = city;
        _province = province;
        _country = country;
        _postalCode = code;
    }
    
    public string GetFullAddress()
    {
        return $"{_street}, {_city}, {_province}, {_country}, {_postalCode}";
    }
}