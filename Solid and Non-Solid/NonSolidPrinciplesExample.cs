using System;

public class ShoppingCart
{
    public double CalculateTotal(double price, string customerType)
    {
        if (customerType == "Student")
        {
            return price * 0.9; // 10% discount for students
        }
        else if (customerType == "Regular")
        {
            return price; // No discount for regular customers
        }
        else
        {
            throw new ArgumentException("Invalid customer type");
        }
    }
}

// Entry point using global code
ShoppingCart cart = new ShoppingCart();
Console.WriteLine("Total price after discount: " + cart.CalculateTotal(100, "Student"));
