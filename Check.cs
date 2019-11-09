using System;
using System.Runtime.Serialization;

[Serializable]
public class Check : ISerializable
{
    public float subtotal;
    public float total;
    public string date = "May 31";
    public string location = "Columbus, OH";

	public Check(float subtotal, string location)
	{
        this.subtotal = subtotal;
        this.total = this.calculateTotal(subtotal);
        this.location = location;
	}

    public Check(SerializationInfo info, StreamingContext ctxt)
    {
        this.subtotal = (float)info.GetValue("subtotal", typeof(float));
        this.total = (float)info.GetValue("total", typeof(float));
        this.date = info.GetValue("date", typeof(string)).ToString();
        this.location = info.GetValue("location", typeof(string)).ToString();
    }

    public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
    {
        info.AddValue("subtotal", this.subtotal);
        info.AddValue("total", this.total);
        info.AddValue("date", this.date);
        info.AddValue("location", this.location);
    }

    public virtual float calculateTotal(float subtotal)
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
