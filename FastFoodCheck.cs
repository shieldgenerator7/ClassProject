using System;

public class FastFoodCheck : Check
{
    public FastFoodCheck(float total, string location)
        : base(total, location)
    {
    }

    public override float calculateTotal(float subtotal)
    {
        this.total = subtotal;
        return this.total;
    }
}
