

public class FruitBag : Product
{
    public int FruitNumber { get; set; }
    public double Weight { get; set; }  // in grams

    public FruitBag(string name, string description, double price, int fruitNumber, double weight) :base(name, description, price)
    {
        FruitNumber = fruitNumber;
        Weight = weight;
    }

    public void AddFruits(int fruitNumber)
    {
        if(FruitNumber + fruitNumber < 10)
        {
            FruitNumber = FruitNumber + fruitNumber;
        }

        else
        {
            Console.WriteLine("Too many fruits! You're gonna break the bag!");
        }
    }

    public void RemoveFruits(int fruitNumber)
    {
        if (FruitNumber - fruitNumber > 0)
        {
            FruitNumber = FruitNumber - fruitNumber;
        }

        else
        {
            Console.WriteLine("You can't remove more fruits than you have!");
        }
    }

    public void RemoveAllFruits()
    {
        FruitNumber = 0;
    }

    public override string GetFullName()
    {
        return base.GetFullName() + "\r\n Weight: " + Weight + ", Fruits number: " + FruitNumber;
    }
}

