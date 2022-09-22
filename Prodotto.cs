

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public double Iva { get; set; }

    public Product(string name, string description, double price)
    {
        Id = new Random().Next(100);
        Name = name;
        Description = description;
        Price = price;
        Iva = Math.Round((Price * 22) / 100, 2);
    }

    public virtual string GetFullName()
    {
        string fullName = Id + "-" + Name;
        return fullName;
    }
}

