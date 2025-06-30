namespace _02.TopicosIniciais.StructuredTypes;

public static class StructuredTypesRunner
{
    public static void Run()
    {
        var p1 = new Product("Laptop", 1000.0, 5);
        var p2 = new Product("Headphones", 200.0, 2);
        
        Console.WriteLine(p1);
        Console.WriteLine(p2);
        
        Console.WriteLine(p1.Name);
        Console.WriteLine(p2.Name);
        
        Console.WriteLine("\n\n----Methods without OO----\n\n");
        Console.WriteLine($"Total p1 = {Total(p1):F2}");
        Console.WriteLine($"Total p2 = {Total(p2):F2}");
        
        Console.WriteLine("\n\n----Updating price----\n\n");
        UpdatePrice(p1, 10);
        UpdatePrice(p2, 20);
        
        Console.WriteLine($"New price p1 = {p1.Price:F2}");
        Console.WriteLine($"New price p2 = {p2.Price:F2}");
        Console.WriteLine("\n\n----End methods without OO----\n\n");
        
        Console.WriteLine("\n\n----Methods with OO----\n\n");
        Console.WriteLine($"Total p1 = {p1.Total():F2}");
        Console.WriteLine($"Total p2 = {p2.Total():F2}");
        
        Console.WriteLine("\n\n----Updating price----\n\n");
        p1.UpdatePrice(10);
        p2.UpdatePrice(20);
        
        Console.WriteLine($"New price p1 = {p1.Price:F2}");
        Console.WriteLine($"New price p2 = {p2.Price:F2}");
        Console.WriteLine("\n\n----End methods with OO----\n\n");
    }

    static double Total(Product product)
    {
        return product.Price * product.Quantity;
    }

    static void UpdatePrice(Product product, int percentage)
    {
        product.Price = product.Price * (1.0 + percentage / 100.0);
    }
}