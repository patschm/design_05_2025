namespace BeverageMachine.Items.Sweeteners;

public abstract class Sweetener : Decorator
{
    protected Sweetener(Beverage beverage) : base(beverage)
    {
    }
}
