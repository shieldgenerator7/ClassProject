using System;

public class Check
{

    public float total;
    public string date = "May 31";
    public string location = "Columbus, OH";

	public Check(float total, string location)
	{
        this.total = total;
        this.location = location;
	}

    public float calculateTotal(float subtotal)
    {
        float tip = subtotal * 0.15f;
        this.total = subtotal + tip;
        return this.total;
    }

    public override string ToString()
    {
        return "Total: " + total + " at location: " + location;
    }
}
