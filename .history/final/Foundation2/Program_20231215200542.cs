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

        productList1.Add(hairP);
        productList1.Add(fruitsP);
        productList1.Add(drinkP);

        Order order1 = new(productList1, customer1);
        Console.WriteLine("Order Number: 1");
        order1.DisplayDetails();
        Console.WriteLine();

        // Second Order
        Address address2 = new("1120 N 850 W St", "Provo", "Utah", "USA");
        Customer customer2 = new("John Black", address2);

        List<Product> productList12= new();
        Product hairP1 = new("Nivea Conditioner", "NC105", 15.99, 1);
        Product fruitsP1 = new("Strawberries", "S0003", 5.99, 1);
        Product drinkP1 = New("Mango Juice", "MJ081", 1.99, 1);

        productList2.Add(hairP1);
        productList2.Add(fruitsP1);
        productList2.Add(drinkP1);

        Order order2 = new(productList2, customer2);
        Console.WriteLine("Order Number: 2");
        order2.DisplayDetails();
        Console.WriteLine();
    }
}