using System;
using System.Collections.Generic;

// Interface Segregation Principle
public interface IDiscountCalculator
{
    double CalculateDiscount(double price);
}

// Open/Closed Principle - can extend functionality without modifying existing code
public class StudentDiscount : IDiscountCalculator
{
    public double CalculateDiscount(double price)
    {
        return price * 0.9; // 10% discount
    }
}

public class RegularDiscount : IDiscountCalculator
{
    public double CalculateDiscount(double price)
    {
        return price; // No discount
    }
}

// Dependency Inversion Principle - depends on abstraction (interface)
public class ShoppingCart
{
    private readonly IDiscountCalculator _discountCalculator;

    public ShoppingCart(IDiscountCalculator discountCalculator)
    {
        _discountCalculator = discountCalculator;
    }

    public double CalculateTotal(double price)
    {
        return _discountCalculator.CalculateDiscount(price);
    }
}

// Entry point using global code
IDiscountCalculator studentDiscount = new StudentDiscount();
ShoppingCart cart = new ShoppingCart(studentDiscount);
Console.WriteLine("Total price after discount: " + cart.CalculateTotal(100));
