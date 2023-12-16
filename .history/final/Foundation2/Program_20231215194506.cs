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
        Product hairP = new("Organics Shampoo", "OS101", 14.99, 2);
        Product fruitsP = new("Green Apples", "GA005", 4.99, 1);
        Product drinkP = New("Fresh Milk", "FM025", 3.99, 2);

        productList1.Add(hairP)
    }
}