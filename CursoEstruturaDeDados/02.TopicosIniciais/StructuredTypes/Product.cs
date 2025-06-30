namespace _02.TopicosIniciais.StructuredTypes;

public class Product
{

    public Product(string name, double price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }
    
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    
    public double Total()
    {
        return Price * Quantity;
    }

    public void UpdatePrice(int percentage)
    {
        Price = Price * (1.0 + percentage / 100.0);
    }

    public override string ToString()
    {
        return $"{Name}, ${Price:F2}, {Quantity}";
    }
}