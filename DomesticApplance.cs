﻿

public class DomesticApplance : Product
{
    public string Type { get; set; }

    public DomesticApplance(string name, string description, double price, string type) :base(name, description, price)
    {
        Type = type;
    }

    public override string GetFullName()
    {
        return base.GetFullName() + "Type: " + Type;
    }
}
