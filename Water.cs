
public class Water : Product
{
    public double Liters { get; set; }
    public int Ph { get; }
    public string Source { get; }

    public Water(string name, string description, double price, double liters, int ph, string source): base(name, description, price)
    {
        Liters = liters;
        Ph = ph;
        Source = source;
    }

    public void Drink(double liters)
    {
        if(Liters - liters >= 0)
        {
            Liters = Liters - liters;
            Console.WriteLine("That's good!");
        } 

        else
        {
            Console.WriteLine("There's not enough water!");
        }
    }

    public void Fill(double liters)
    {
        if(this.Liters + liters < 1.5)
        {
            this.Liters = this.Liters + liters;
            Console.WriteLine("Correctly Filled!");
        } 

        else
        {
            Console.WriteLine("There's too much water!");
        }
    }

    public void Empty(double liters)
    {
        this.Liters = 0;
        Console.WriteLine("There's no water now");
    }

    public static double ToGallons(double liters)
    {
        return liters * 3.785;
    }

    public override string GetFullName() {
        return base.GetFullName() + "\r\n Source: " + Source + ", Ph: " + Ph + ", Liters: " + Liters;
    }
}

