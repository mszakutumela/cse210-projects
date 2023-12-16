using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        Console.WriteLine();

        // First Order
        Address address1 = new("Cantonments Road 116", "Centurion", "Gauteng", "South Africa");
        Customer customer1 = new("Ayanda Ndlovu", address1);

        List<Product> productList1 = new();
        Product hair = new("Organics Shampoo", "OS101", 74.99, 2);
        Product fruits = new("Green Apples")
    }
}