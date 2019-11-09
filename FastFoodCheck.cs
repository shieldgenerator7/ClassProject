using System;
using System.Runtime.Serialization;

[Serializable]
public class FastFoodCheck : Check
{
    public FastFoodCheck(float total, string location)
        : base(total, location)
    {
    }

    public FastFoodCheck(SerializationInfo info, StreamingContext ctxt)
        : base(info, ctxt)
    {
    }

    public override float calculateTotal(float subtotal)
    {
        this.total = subtotal;
        return this.total;
    }
}
