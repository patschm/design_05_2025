﻿namespace BeverageMachine.Items.Sauces;

public abstract class Sauce : Decorator
{
    protected Sauce(Beverage beverage) : base(beverage)
    {
    }
}
