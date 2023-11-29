using System;

// Step 3: Create the Fraction class
// 1. Create a class to hold fraction.
// 2. The class should be in its own file.
// 3. he class should have two attributes for the top and bottom numbers.
// 4. Make sure the attributes are private.

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int topNumber)
    {
        _numerator = topNumber;
        _denominator = 1;
    }

    public Fraction(int top, int bottom)
    {
        _numerator = top;
        _denominator = bottom;
    }

    // Step 5: Create the Getters and Setters 
    public int GetTopNumber()
    {
        return _numerator;
    }

    public int GetBottomNumber()
    {
        return _denominator;
    }

    public void SetTopNumber(int topNumber)
    {
        _numerator = topNumber;
    }

    public void SetBottomNumber(int bottomNumber)
    {
        _denominator = bottomNumber;
    }

    // Step 6: Create methods to return the representations
    // 1. Create a method called GetFractionString that returns the fraction in the form 3/4.
    // 2. Create a method called GetDecimalValue that returns a double that is the result of 
    // dividing the top number by the bottom number, such as 0.75.
    public string GetFractionString()
    {
        string fraction = $"{_numerator} / {_denominator}";

        return fraction;
    }

    public double GetDecimalValue();
    {
        double fraction = Convert.ToDouble(_numerator) / Convert.ToDouble(_denominator);
        
    }
