namespace BeverageMachine.Items;

public abstract class Beverage
{
   // readonly Beverage? _beverage;
    public abstract float? Price { get; }
    public abstract void Brew();

    //public Beverage(Beverage? beverage)
    //{
    //    // = beverage;
    //}
}
