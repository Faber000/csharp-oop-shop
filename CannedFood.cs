
public class CannedFood : Product
{
    public double Weight { get; set; }
    public string Type { get; set; }    
    public DateTime ExpiringDate { get; set; }

    public CannedFood(string name, string description, double price, double weight, string type, DateTime expiringDate) :base(name, description, price)    
    {
        Weight = weight;
        Type = type;
        ExpiringDate = expiringDate;
    }

    public void Eat()
    {
        DateTime thisDay = DateTime.Now;

        if (DateTime.Compare(thisDay, ExpiringDate) < 0)
        {
            Console.WriteLine("That's good!");
        }
        
        else
        {
            Console.WriteLine("Wait! don't eat it!");
        }
    }

    public override string GetFullName()
    {
        return base.GetFullName() + "\r\n Weight: " + Weight + ", Type: " + Type;
    }
}

