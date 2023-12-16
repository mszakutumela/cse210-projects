using System;

public class Address
{
    private string _street;
    private string _city;
    private string _province;
    private string _country;
    private int _postalCode;

    public Address(string street, string city, string province, string country, int c)
    {
        _street = street;
        _city = city;
        _province = province;
        _country = country;
    }
    
    public string GetFullAddress()
    {
        
    }
}