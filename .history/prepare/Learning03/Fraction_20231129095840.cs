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

    public
}
