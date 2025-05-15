namespace BeverageMachine.Items.Toppings;

public abstract class Topping : Decorator
{
    protected Topping(Beverage beverage) : base(beverage)
    {
    }
}
